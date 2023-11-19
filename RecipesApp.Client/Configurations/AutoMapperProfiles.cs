using AutoMapper;
using RecipesApp.Shared.DTOs.Recipe;

namespace RecipesApp.Client.Configurations
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RecipeReadOnlyDetailsDto, RecipeUpsertDto>();
        }
    }
}
