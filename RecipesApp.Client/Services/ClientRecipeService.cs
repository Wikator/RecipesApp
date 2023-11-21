using Newtonsoft.Json;
using RecipesApp.Shared.DTOs.Recipe;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using System.Net.Http.Json;

namespace RecipesApp.Client.Services
{
    public class ClientRecipeService(HttpClient http) : IRecipeService
    {
        private HttpClient Http { get; } = http;
        private const string BaseUrl = "api/recipes/";

        public async Task<ServiceResult<RecipeReadOnlyDetailsDto>> AddAsync(RecipeCreateDto item)
        {
            var response = await Http.PostAsJsonAsync(BaseUrl, item);

            if (response.IsSuccessStatusCode)
            {
                var recipe = await response.Content.ReadFromJsonAsync<RecipeReadOnlyDetailsDto>()
                    ?? throw new Exception("API didn't return new object, despite sucessfully creating it");

                return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateSuccessfulResult(recipe, response.StatusCode);
            }

            var message = await response.Content.ReadAsStringAsync();
            return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateFailedResult(message, response.StatusCode);

        }

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            var response = await Http.DeleteAsync($"{BaseUrl}{id}");

            if (response.IsSuccessStatusCode)
                return ServiceResult.GenerateSuccessfulResult(response.StatusCode);

            var message = await response.Content.ReadAsStringAsync();
            return ServiceResult.GenerateFailedResult(message, response.StatusCode);
        }

        public async Task<ServiceResult<IEnumerable<RecipeReadOnlyDetailsDto>>> GetAllAsync(string? orderQuerry,
            string? filter)
        {
            var url = $"{BaseUrl}?orderBy={orderQuerry}&filter={filter}";
            var recipes = await Http.GetFromJsonAsync<IEnumerable<RecipeReadOnlyDetailsDto>>(url)
                ?? Enumerable.Empty<RecipeReadOnlyDetailsDto>();

            return ServiceResult<IEnumerable<RecipeReadOnlyDetailsDto>>.GenerateSuccessfulResult(recipes, System.Net.HttpStatusCode.OK);
        }

        public async Task<ServiceResult<RecipeReadOnlyDetailsDto>> GetByIdAsync(int id)
        {
            var response = await Http.GetAsync($"{BaseUrl}{id}");

            if (response.IsSuccessStatusCode)
            {
                var recipe = await response.Content.ReadFromJsonAsync<RecipeReadOnlyDetailsDto>()
                    ?? throw new Exception();

                return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateSuccessfulResult(recipe, response.StatusCode);
            }

            var message = await response.Content.ReadAsStringAsync();
            return ServiceResult<RecipeReadOnlyDetailsDto>.GenerateFailedResult(message, response.StatusCode);
        }

        public async Task<ServiceResult<PagedList<RecipeReadOnlyDto>>> GetPagedItemsAsync(int pageNumber, int itemsPerPage,
            string? orderQuerry, string? filter)
        {
            var url = $"{BaseUrl}?pageNumber={pageNumber}&pageSize={itemsPerPage}&orderBy={orderQuerry}&filter={filter}";
            var response = await Http.GetAsync(url);
            
            var recipes = await response.Content.ReadFromJsonAsync<IEnumerable<RecipeReadOnlyDto>>()
                ?? throw new Exception();

            var paginationHeader = response.Headers.GetValues("Pagination").FirstOrDefault()
                ?? throw new Exception();

            var deserializedPaginationHeader = JsonConvert.DeserializeObject<PaginationHeader>(paginationHeader)
                ?? throw new Exception();

            var pagedRecipes =  new PagedList<RecipeReadOnlyDto>(recipes, deserializedPaginationHeader.CurrentPage,
                deserializedPaginationHeader.ItemsPerPage, deserializedPaginationHeader.TotalItems);

            return ServiceResult<PagedList<RecipeReadOnlyDto>>.GenerateSuccessfulResult(pagedRecipes, response.StatusCode);
        }

        public async Task<ServiceResult> UpdateAsync(int id, RecipeUpdateDto item)
        {
            var response = await Http.PutAsJsonAsync($"{BaseUrl}{id}", item);

            if (response.IsSuccessStatusCode)
            {
                return ServiceResult.GenerateSuccessfulResult(response.StatusCode);
            }

            var message = await response.Content.ReadAsStringAsync();
            return ServiceResult.GenerateFailedResult(message, response.StatusCode);
        }
    }
}
