using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Extensions;
using RecipesApp.Services.Contracts;
using RecipesApp.Shared.DTOs.Recipe;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using System.Linq.Dynamic.Core;
using System.Net;

namespace RecipesApp.Services
{
    public class RecipeService(ApplicationDbContext db, IMapper mapper,
        IHttpContextAccessor httpContextAccessor, IPhotoService photoService) : IRecipeService
    {
        private ApplicationDbContext Db { get; } = db;
        private IMapper Mapper { get; } = mapper;
        private IHttpContextAccessor HttpContext { get; } = httpContextAccessor;
        private IPhotoService PhotoService { get; } = photoService;

        public async Task<ServiceResult<RecipeReadOnlyDetailsDto>> AddAsync(RecipeCreateDto item)
        {
            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (userId is null)
                return ServiceResult<RecipeReadOnlyDetailsDto>
                    .GenerateFailedResult("User unauthorized", HttpStatusCode.Unauthorized);

            var recipe = new Recipe()
            {
                Name = item.Name,
                AuthorId = userId
            };

            Mapper.Map(item, recipe);

            if (item.FileContent is not null)
            {
                var file = new FormFile(
                    new MemoryStream(item.FileContent),
                    0,
                    item.FileContent.Length,
                    "file", item.FileName ?? $"recipe-{recipe.AuthorId}");

                var uploadResult = await PhotoService.AddPhotoAsync(file);
                if (uploadResult.Error is not null)
                    return ServiceResult<RecipeReadOnlyDetailsDto>
                        .GenerateFailedResult("Image Failed to save", HttpStatusCode.BadRequest);

                recipe.Picture = new()
                {
                    Url = uploadResult.SecureUrl.AbsoluteUri,
                    PublicId = uploadResult.PublicId
                };
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
                return ServiceResult.GenerateFailedResult("Recipe does not exist",
                    HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (recipe.AuthorId != userId)
                return ServiceResult.GenerateFailedResult("You can't delete other users' recipes",
                    HttpStatusCode.Unauthorized);

            if (recipe.Picture is not null)
            {
                var deleteResult = await PhotoService.DeletePhotoAsync(recipe.Picture.PublicId);

                if (deleteResult.Error is not null)
                    return ServiceResult.GenerateFailedResult("Image Failed to delete",
                        HttpStatusCode.BadRequest);
            }

            Db.Recipes.Remove(recipe);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
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

        public async Task<PagedList<RecipeReadOnlyDto>> GetPagedItemsAsync(int pageNumber, int itemsPerPage,
            string? orderQuerry, string? filter)
        {
            var query = filter switch
            {
                null => Db.Recipes,
                _ => Db.Recipes.Where(r => r.Name.Contains(filter))
            };

            return await query
                .ApplySort(orderQuerry)
                .ProjectTo<RecipeReadOnlyDto>(Mapper.ConfigurationProvider)
                .CreatePagedList(pageNumber, itemsPerPage);
        }

        public async Task<PagedList<RecipeReadOnlyDto>> GetPagedItemsAsync(int pageNumber, int itemsPerPage)
        {
            return await Db.Recipes
                .ProjectTo<RecipeReadOnlyDto>(Mapper.ConfigurationProvider)
                .CreatePagedList(pageNumber, itemsPerPage);
        }

        public async Task<ServiceResult<PagedList<RecipeReadOnlyDto>>> GetUserPagedItemsAsync(int pageNumber, int itemsPerPage, string? orderQuerry, string? filter)
        {
            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (userId is null)
                return ServiceResult<PagedList<RecipeReadOnlyDto>>
                    .GenerateFailedResult("User unauthorized", HttpStatusCode.Unauthorized);

            var query = Db.Recipes.Where(r => r.AuthorId == userId);

            if (filter is not null)
                query = query.Where(filter);

            var recipes = await query
                .ApplySort(orderQuerry)
                .ProjectTo<RecipeReadOnlyDto>(Mapper.ConfigurationProvider)
                .CreatePagedList(pageNumber, itemsPerPage);

            return ServiceResult<PagedList<RecipeReadOnlyDto>>.GenerateSuccessfulResult(recipes, HttpStatusCode.OK);
        }

        public async Task<ServiceResult> UpdateAsync(int id, RecipeUpdateDto item)
        {
            var recipe = await Db.Recipes
                .Include(r => r.Picture)
                .Include(r => r.Ingredients)
                .Where(r => r.Id == id)
                .SingleOrDefaultAsync();

            if (recipe is null)
                return ServiceResult
                    .GenerateFailedResult("Recipe does not exist", HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (recipe.AuthorId != userId)
                return ServiceResult
                    .GenerateFailedResult("You can't edit other users' recipes", HttpStatusCode.Unauthorized);

            if (recipe.Picture is not null && !item.UseOldPicture)
            {
                var deleteResult = await PhotoService.DeletePhotoAsync(recipe.Picture.PublicId);

                if (deleteResult.Error is not null)
                    return ServiceResult
                        .GenerateFailedResult("Image to replace image. Try again later", HttpStatusCode.BadRequest);

                recipe.Picture = null;
            }

            if (recipe.Ingredients is not null)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    if (!item.Ingredients.Select(i => i.Id).Contains(ingredient.Id))
                    {
                        Db.Remove(ingredient);
                    }
                }
            }

            Mapper.Map(item, recipe);

            if (item.FileContent is not null && !item.UseOldPicture)
            {
                var file = new FormFile(
                    new MemoryStream(item.FileContent),
                    0,
                    item.FileContent.Length,
                    "file", item.FileName ?? $"recipe {id}");

                var uploadResult = await PhotoService.AddPhotoAsync(file);
                if (uploadResult.Error is not null)
                    return ServiceResult
                        .GenerateFailedResult("Image Failed to save", HttpStatusCode.BadRequest);

                recipe.Picture = new()
                {
                    Url = uploadResult.SecureUrl.AbsoluteUri,
                    PublicId = uploadResult.PublicId
                };
            }

            Db.Recipes.Update(recipe);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
        }
    }
}
