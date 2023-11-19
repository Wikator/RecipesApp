using RecipesApp.Shared.DTOs.Recipe;
using RecipesApp.Shared.Helpers;

namespace RecipesApp.Shared.Interfaces
{
    public interface IRecipeService
    {
        /// <summary>
        /// Gets all existing recipes
        /// </summary>
        /// <returns>200 (with all recipes)</returns>
        Task<ServiceResult<IEnumerable<RecipeReadOnlyDetailsDto>>> GetAllAsync();

        /// <summary>
        /// Gets a recipe by id
        /// </summary>
        /// <param name="id">Id of recipe to retrieve</param>
        /// <returns>200 (with a recipe), 404</returns>
        Task<ServiceResult<RecipeReadOnlyDetailsDto>> GetByIdAsync(int id);

        /// <summary>
        /// Gets paginated recipes
        /// </summary>
        /// <param name="pageNumber">Number of a page</param>
        /// <param name="itemsPerPage">How many recipes should there be on one page</param>
        /// <returns>200 (with paginated recipes)</returns>
        Task<ServiceResult<PagedList<RecipeReadOnlyDto>>> GetPagedItemsAsync(int pageNumber, int itemsPerPage);

        /// <summary>
        /// Adds a new recipe to database
        /// </summary>
        /// <param name="item">A dto to convert into entity, and add to database</param>
        /// <returns>201 (with newly added entity), 400</returns>
        /// <exception cref="InvalidOperationException">Called when user is not authenticated</exception>
        Task<ServiceResult<RecipeReadOnlyDetailsDto>> AddAsync(RecipeUpsertDto item);

        /// <summary>
        /// Updates an existing recipes
        /// </summary>
        /// <param name="id">Id of a recipe to update</param>
        /// <param name="item">How the new recipe should look like</param>
        /// <returns>204, 401, 404</returns>
        /// <exception cref="InvalidOperationException">Called when user is not authenticated</exception>
        Task<ServiceResult> UpdateAsync(int id, RecipeUpsertDto item);

        /// <summary>
        /// Removes recipe from database
        /// </summary>
        /// <param name="id">An id of recipe to delete</param>
        /// <returns>204, 400, 401, 404</returns>
        /// <exception cref="InvalidOperationException">Called when user is not authenticated</exception>
        Task<ServiceResult> DeleteAsync(int id);
    }
}
