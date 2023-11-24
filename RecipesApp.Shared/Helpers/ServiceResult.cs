using System.Net;

namespace RecipesApp.Shared.Helpers
{
    public class ServiceResult<T>
    {
        public bool IsSuccessful { get; set; }
        public T? Data { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string Message { get; set; } = "Operation complted succesfully";

        public static ServiceResult<T> GenerateSuccessfulResult(T result, HttpStatusCode statusCode) =>
            new()
            {
                IsSuccessful = true,
                Data = result,
                StatusCode = statusCode
            };

        public static ServiceResult<T> GenerateFailedResult(string message, HttpStatusCode statusCode) =>
            new()
            {
                StatusCode = statusCode,
                Message = message
            };
    }

    public class ServiceResult
    {
        public bool IsSuccessful { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string Message { get; set; } = "Operation complted succesfully";

        public static ServiceResult GenerateSuccessfulResult(HttpStatusCode statusCode) =>
            new()
            {
                IsSuccessful = true,
                StatusCode = statusCode
            };

        public static ServiceResult GenerateFailedResult(string message, HttpStatusCode statusCode) =>
            new()
            {
                StatusCode = statusCode,
                Message = message
            };
    }
}
