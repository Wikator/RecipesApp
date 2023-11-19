using System.Net;

namespace RecipesApp.Client.Exceptions
{
    public class ApiException(string message, HttpStatusCode statusCode) : Exception(message)
    {
        public HttpStatusCode? StatusCode { get; } = statusCode;
    }
}
