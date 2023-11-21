using AutoMapper;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Shared.DTOs.ApplicationUser;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.DTOs.Recipe;

namespace RecipesApp.Configurations
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Recipe, RecipeReadOnlyDto>().ForMember(src => src.ImageUrl,
                conf => conf.MapFrom(dest => dest.Picture == null ? null : dest.Picture.Url));

            CreateMap<Recipe, RecipeReadOnlyDetailsDto>().ForMember(src => src.ImageUrl,
                conf => conf.MapFrom(dest => dest.Picture == null ? null : dest.Picture.Url));

            CreateMap<Comment, CommentReadOnlyDto>().ForMember(src => src.Author,
                conf => conf.MapFrom(dest => dest.Author == null ? null : dest.Author.UserName));

            CreateMap<CommentUpsertDto, Comment>();
            CreateMap<RecipeCreateDto, Recipe>();
            CreateMap<RecipeUpdateDto, Recipe>();
            CreateMap<ApplicationUser, ApplicationUserReadOnlyDto>();
        }
    }
}
