using System.Security.Claims;

namespace RecipesApp.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string? GetLoggedInUserId(this ClaimsPrincipal user)
        {
            var claimsIdentity = (user.Identity as ClaimsIdentity);
            var claim = claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier);
            return claim?.Value;
        }
    }
}
