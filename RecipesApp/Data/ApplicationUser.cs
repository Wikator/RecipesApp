using Microsoft.AspNetCore.Identity;
using RecipesApp.Entities;

namespace RecipesApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<Comment>? Comments { get; set; }
    }

}
