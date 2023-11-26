using Microsoft.AspNetCore.Identity;
using RecipesApp.Data;

namespace RecipesApp.Validators
{
    public class UniqueEmailValidator : IUserValidator<ApplicationUser>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            var errors = new List<IdentityError>();

            var email = (await manager.GetEmailAsync(user))?.ToUpper();
            if (!string.IsNullOrEmpty(email))
            {
                var existingUser = manager.Users.SingleOrDefault(u => u.Id != user.Id && u.NormalizedEmail == email);
                if (existingUser != null)
                {
                    errors.Add(new IdentityError
                    {
                        Code = "DuplicateEmail",
                        Description = $"Email '{email.ToLower()}' is already taken."
                    });
                }
            }

            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed([.. errors]);
        }
    }
}