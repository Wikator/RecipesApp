using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Extensions;
using RecipesApp.Services.Contracts;
using RecipesApp.Shared.DTOs.Recipe;
using System.Net;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace RecipesApp.Services
{
    public class RecipeService(ApplicationDbContext db, IMapper mapper,
        IHttpContextAccessor httpContextAccessor, IPhotoService photoService) : IRecipeService
    {
        private ApplicationDbContext Db { get; } = db;
        private IMapper Mapper { get; } = mapper;
        private IHttpContextAccessor HttpContext { get; } = httpContextAccessor;
        private IPhotoService PhotoService { get; } = photoService;

        public async Task<ServiceResult<RecipeReadOnlyDetailsDto>> AddAsync(RecipeUpsertDto item)
        {
            var recipe = new Recipe()
            {
                Name = item.Name,
                AuthorId = HttpContext.HttpContext?.User.GetLoggedInUserId()
                    ?? throw new Exception()
            };
            
            Mapper.Map(item, recipe);

            if (item.FileContent is not null)
            {
                var file = new FormFile(new MemoryStream(item.FileContent), 0, item.FileContent.Length, "file", item.FileName ?? $"recipe {recipe.AuthorId}");
                var uploadResult = await PhotoService.AddPhotoAsync(file);
                if (uploadResult.Error is not null)
                    return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateFailedResult("Image Failed to save", HttpStatusCode.BadRequest);

                recipe.Picture = new() { Url = uploadResult.SecureUrl.AbsoluteUri, PublicId = uploadResult.PublicId };
            }

            Db.Recipes.Add(recipe);
            await Db.SaveChangesAsync();

            return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateSuccessfulResult(
                Mapper.Map<RecipeReadOnlyDetailsDto>(recipe), HttpStatusCode.Created);
        }

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            var recipe = await Db.Recipes
                .Include(r => r.Picture)
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            if (recipe is null)
                return ServiceResult.GenerateFailedResult("Recipe does not exist", HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (recipe.AuthorId != userId)
                return ServiceResult.GenerateFailedResult("You can't delete other users' recipes", HttpStatusCode.Unauthorized);

            if (recipe.Picture is not null)
            {
                var deleteResult = await PhotoService.DeletePhotoAsync(recipe.Picture.PublicId);

                if (deleteResult.Error is not null)
                    return ServiceResult.GenerateFailedResult("Image Failed to delete", HttpStatusCode.BadRequest);
            }

            Db.Recipes.Remove(recipe);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
        }

        public async Task<ServiceResult<IEnumerable<RecipeReadOnlyDetailsDto>>> GetAllAsync()
        {
            var recipes = await Db.Recipes
                .ProjectTo<RecipeReadOnlyDetailsDto>(Mapper.ConfigurationProvider)
                .ToListAsync();

            return ServiceResult<IEnumerable<RecipeReadOnlyDetailsDto>>.GenerateSuccessfulResult(
                recipes, HttpStatusCode.OK);
        }

        public async Task<ServiceResult<RecipeReadOnlyDetailsDto>> GetByIdAsync(int id)
        {
            var recipe = await Db.Recipes
                .Where(r => r.Id == id)
                .ProjectTo<RecipeReadOnlyDetailsDto>(Mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();

            if (recipe is null)
                return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateFailedResult("Recipe does not exist",
                    HttpStatusCode.NotFound);

            return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateSuccessfulResult(recipe, HttpStatusCode.OK);
        }

        public async Task<ServiceResult<PagedList<RecipeReadOnlyDto>>> GetPagedItemsAsync(int pageNumber, int itemsPerPage, string? orderQuerry)
        {
            var pagedList = await Db.Recipes
                .ApplySort(orderQuerry)
                .ProjectTo<RecipeReadOnlyDto>(Mapper.ConfigurationProvider)
                .CreatePagedList(pageNumber, itemsPerPage);

            return ServiceResult<PagedList<RecipeReadOnlyDto>>.GenerateSuccessfulResult(pagedList, HttpStatusCode.OK);
        }

        public async Task<ServiceResult> UpdateAsync(int id, RecipeUpsertDto item)
        {
            var recipe = await Db.Recipes
                .Include(r => r.Picture)
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            if (recipe is null)
                return ServiceResult.GenerateFailedResult("Recipe does not exist", HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (recipe.AuthorId != userId)
                return ServiceResult.GenerateFailedResult("You can't edit other users' recipes", HttpStatusCode.Unauthorized);

            if (recipe.Picture is not null)
            {
                var deleteResult = await PhotoService.DeletePhotoAsync(recipe.Picture.PublicId);

                if (deleteResult.Error is not null)
                    return ServiceResult.GenerateFailedResult("Image to replace image. Try again later", HttpStatusCode.BadRequest);
            }

            Mapper.Map(item, recipe);

            if (item.FileContent is not null)
            {
                var file = new FormFile(new MemoryStream(item.FileContent), 0, item.FileContent.Length, "file", item.FileName ?? $"recipe {id}");
                var uploadResult = await PhotoService.AddPhotoAsync(file);
                if (uploadResult.Error is not null)
                    return ServiceResult.GenerateFailedResult("Image Failed to save", HttpStatusCode.BadRequest);

                recipe.Picture = new() { Url = uploadResult.SecureUrl.AbsoluteUri, PublicId = uploadResult.PublicId };
            }

            Db.Recipes.Update(recipe);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
        }
    }
}
