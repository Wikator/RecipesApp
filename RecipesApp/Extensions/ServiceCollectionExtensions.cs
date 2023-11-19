using RecipesApp.Configurations;
using RecipesApp.Services;
using RecipesApp.Services.Contracts;
using RecipesApp.Shared.Interfaces;

namespace RecipesApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IPhotoService, PhotoService>();

            services.AddAutoMapper(typeof(AutoMapperProfiles));

            services.AddHttpContextAccessor();
        }

        public static void AddClientService(this IServiceCollection services)
        {
        }
    }
}
