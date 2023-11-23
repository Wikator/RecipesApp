using AutoMapper;
using System.Net;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using RecipesApp.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace RecipesApp.Services
{
    public class CommentService(ApplicationDbContext db, IMapper mapper,
        IHttpContextAccessor httpContextAccessor) : ICommentService
    {
        private ApplicationDbContext Db { get; } = db;
        private IMapper Mapper { get; } = mapper;
        private IHttpContextAccessor HttpContext { get; } = httpContextAccessor;


        public async Task<ServiceResult<CommentReadOnlyDto>> AddComment(CommentUpsertDto item)
        {
            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (userId is null)
                return ServiceResult<CommentReadOnlyDto>
                    .GenerateFailedResult("User unauthorized", HttpStatusCode.Unauthorized);

            var comment = new Comment()
            {
                Text = item.Text,
                AuthorId = userId
            };

            Mapper.Map(item, comment);
            Db.Comments.Add(comment);
            await Db.SaveChangesAsync();

            comment.Author = await Db.Users.FindAsync(comment.AuthorId);

            return ServiceResult<CommentReadOnlyDto>.GenerateSuccessfulResult(
                Mapper.Map<CommentReadOnlyDto>(comment), HttpStatusCode.Created);
        }

        public async Task<ServiceResult> DeleteComment(int id)
        {
            var comment = await Db.Comments.FindAsync(id);

            if (comment is null)
                return ServiceResult.GenerateFailedResult("Comment not found", HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (comment.AuthorId != userId) 
                return ServiceResult.GenerateFailedResult(
                    "You can't delete other users' comments", HttpStatusCode.Unauthorized);

            Db.Comments.Remove(comment);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
        }

        public async Task<IEnumerable<CommentReadOnlyDto>> GetComments(int recipeId)
        {
            return await Db.Comments
                .Where(c => c.RecipeId == recipeId)
                .ProjectTo<CommentReadOnlyDto>(Mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ServiceResult> UpdateComment(int id, CommentUpsertDto item)
        {
            var comment = await Db.Comments.FindAsync(id);

            if (comment is null)
                return ServiceResult.GenerateFailedResult("Comment not found", HttpStatusCode.NotFound);

            var userId = HttpContext.HttpContext?.User.GetLoggedInUserId();

            if (comment.AuthorId != userId)
                return ServiceResult.GenerateFailedResult(
                    "You can't edit other users' comments", HttpStatusCode.Unauthorized);

            Mapper.Map(item, comment);
            Db.Comments.Update(comment);
            await Db.SaveChangesAsync();
            return ServiceResult.GenerateSuccessfulResult(HttpStatusCode.NoContent);
        }
    }
}
