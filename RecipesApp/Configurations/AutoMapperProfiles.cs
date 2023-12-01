using AutoMapper;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Shared.DTOs.ApplicationUser;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.DTOs.Ingredient;
using RecipesApp.Shared.DTOs.Recipe;

namespace RecipesApp.Configurations
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Recipe, RecipeReadOnlyDto>()
                .ForMember(dest => dest.ImageUrl,
                    conf => conf.MapFrom(src => src.Picture == null ? null : src.Picture.Url))
                .ForMember(dest => dest.Rating,
                    conf => conf.MapFrom(src => src.RecipeReviews!.Count != 0 ? src.RecipeReviews!.Average(r => r.Score) : 0));

            CreateMap<Recipe, RecipeReadOnlyDetailsDto>()
                .ForMember(dest => dest.ImageUrl,
                conf => conf.MapFrom(src => src.Picture == null ? null : src.Picture.Url));

            CreateMap<Comment, CommentReadOnlyDto>()
                .ForMember(dest => dest.Author,
                conf => conf.MapFrom(src => src.Author == null ? null : src.Author.UserName));

            CreateMap<CommentUpsertDto, Comment>();
            CreateMap<RecipeCreateDto, Recipe>();
            CreateMap<RecipeUpdateDto, Recipe>();
            CreateMap<Ingredient, IngredientReadOnlyDto>();
            CreateMap<IngredientUpsertDto, Ingredient>();
            CreateMap<ApplicationUser, ApplicationUserReadOnlyDto>();
        }
    }
}
