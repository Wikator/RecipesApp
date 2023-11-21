
using RecipesApp.Shared.DTOs.Ingredient;
using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Shared.DTOs.Recipe
{
    public class RecipeUpdateDto
    {
        [Required]
        public required string Name { get; set; }
        public string? Text { get; set; }
        public string? FileName { get; set; }
        public byte[]? FileContent { get; set; }
        public bool UseOldPicture { get; set; }
        public List<IngredientUpsertDto> Ingredients { get; init; } = [];
    }
}
