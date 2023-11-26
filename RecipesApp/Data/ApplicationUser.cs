using Microsoft.AspNetCore.Identity;
using RecipesApp.Entities;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public override string? UserName { get => base.UserName; set => base.UserName = value; }

        [Required]
        public override string? NormalizedUserName { get => base.NormalizedUserName; set => base.NormalizedUserName = value; }

        [Required]
        public override string? Email { get => base.Email; set => base.Email = value; }

        [Required]
        public override string? NormalizedEmail { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }



        public List<Comment>? Comments { get; set; }
    }

}
