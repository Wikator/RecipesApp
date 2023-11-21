using AutoMapper;
using RecipesApp.Shared.DTOs.Ingredient;
using RecipesApp.Shared.DTOs.Recipe;

namespace RecipesApp.Client.Configurations
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RecipeReadOnlyDetailsDto, RecipeUpdateDto>().ForMember(dest => dest.UseOldPicture,
                opt => opt.MapFrom(src => src.ImageUrl != null));

            CreateMap<IngredientReadOnlyDto, IngredientUpsertDto>();
        }
    }
}
