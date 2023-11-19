using RecipesApp.Shared.DTOs.ApplicationUser;

namespace RecipesApp.Shared.DTOs.Recipe
{
    public class RecipeReadOnlyDto
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public string? ImageUrl { get; init; }
        public required ApplicationUserReadOnlyDto Author { get; init; }
    }
}
