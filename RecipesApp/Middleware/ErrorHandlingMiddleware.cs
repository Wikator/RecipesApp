using Microsoft.EntityFrameworkCore;
using System.Net;

namespace RecipesApp.Middleware
{
    public class ErrorHandlingMiddleware(RequestDelegate next)
    {
        private RequestDelegate Next { get; } = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            
            switch (exception)
            {
                case DbUpdateException ex:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    return context.Response.WriteAsync(ex.Message ?? "Error updating the database.");
                    
                default:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    return context.Response.WriteAsync("An unexpected error occurred.");
            }
        }
    }
}
