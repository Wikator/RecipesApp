using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.Helpers;

namespace RecipesApp.Shared.Interfaces
{
    public interface ICommentService
    {
        /// <summary>
        /// Gets all comments related to a recipe
        /// </summary>
        /// <param name="recipeId">Id of a recipe</param>
        /// <returns>200 (with comments)</returns>
        Task<IEnumerable<CommentReadOnlyDto>> GetComments(int recipeId);

        /// <summary>
        /// Add a new comment to database
        /// </summary>
        /// <param name="item">A dto to convert into entity, and add to database</param>
        /// <returns>201 (with newly added comment)</returns>
        /// <exception cref="InvalidOperationException">Called when user is not authenticated</exception>
        Task<ServiceResult<CommentReadOnlyDto>> AddComment(CommentUpsertDto item);

        /// <summary>
        /// Updates an existing comment
        /// </summary>
        /// <param name="id">Id of a recipe to update</param>
        /// <param name="item">How the new recipe should look like</param>
        /// <returns>204, 401, 404</returns>
        Task<ServiceResult> UpdateComment(int id, CommentUpsertDto item);

        /// <summary>
        /// Deletes comment from database
        /// </summary>
        /// <param name="id">An id of comment to delete</param>
        /// <returns>204, 401, 404</returns>
        Task<ServiceResult> DeleteComment(int id);
    }
}
