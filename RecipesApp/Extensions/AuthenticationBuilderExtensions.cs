using Microsoft.AspNetCore.Authentication;

namespace RecipesApp.Extensions
{
    public static class AuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddExternalServices(this AuthenticationBuilder builder, IConfiguration config)
        {
            builder.AddMicrosoftAccount(microsoftOptions =>
            {
                microsoftOptions.ClientId = config["Authentication:Microsoft:ClientId"]
                    ?? throw new Exception("Microsoft Authentication ClientId is not configured");

                microsoftOptions.ClientSecret = config["Authentication:Microsoft:ClientSecret"]
                    ?? throw new Exception("Microsoft Authentication ClientSecret is not configured");
            });

            builder.AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = config["Authentication:Google:ClientId"]
                    ?? throw new Exception("Google Authentication ClientId is not configured");

                googleOptions.ClientSecret = config["Authentication:Google:ClientSecret"]
                    ?? throw new Exception("Google Authentication ClientSecret is not configured");
            });

            return builder;
        }
    }
}
