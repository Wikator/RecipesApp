using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace RecipesApp.Client.Services
{
    public class ClientCommentService(HttpClient http) : ICommentService
    {
        private HttpClient Http { get; } = http;
        private const string BaseUrl = "api/comments/";

        public async Task<ServiceResult<CommentReadOnlyDto>> AddComment(CommentUpsertDto item)
        {
            var response = await Http.PostAsJsonAsync(BaseUrl, item);

            if (!response.IsSuccessStatusCode)
                return ServiceResult<CommentReadOnlyDto>.GenerateFailedResult(
                    await response.Content.ReadAsStringAsync(), response.StatusCode);

            Console.WriteLine(response.StatusCode);

            var comment = await response.Content.ReadFromJsonAsync<CommentReadOnlyDto>()
                ?? throw new Exception();

            return ServiceResult<CommentReadOnlyDto>.GenerateSuccessfulResult(comment,
                response.StatusCode);
        }

        public async Task<ServiceResult> DeleteComment(int id)
        {
            var response = await Http.DeleteAsync(BaseUrl + id);

            if (!response.IsSuccessStatusCode)
                return ServiceResult.GenerateFailedResult(await response.Content.ReadAsStringAsync(),
                    response.StatusCode);

            return ServiceResult.GenerateSuccessfulResult(response.StatusCode);
        }

        public async Task<IEnumerable<CommentReadOnlyDto>> GetComments(int recipeId)
        {
            return await Http.GetFromJsonAsync<IEnumerable<CommentReadOnlyDto>>(BaseUrl + recipeId)
                ?? Enumerable.Empty<CommentReadOnlyDto>();
        }

        public async Task<ServiceResult> UpdateComment(int id, CommentUpsertDto item)
        {
            var response = await Http.PutAsJsonAsync(BaseUrl + id, item);

            if (!response.IsSuccessStatusCode)
                return ServiceResult.GenerateFailedResult(await response.Content.ReadAsStringAsync(),
                    response.StatusCode);

            return ServiceResult.GenerateSuccessfulResult(response.StatusCode);
        }
    }
}
