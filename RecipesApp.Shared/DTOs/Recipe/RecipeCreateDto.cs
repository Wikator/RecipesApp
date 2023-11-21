using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Shared.DTOs.Recipe
{
    public class RecipeCreateDto
    {
        [Required]
        public string Name { get; set; } = "New Recipe";
        public string? Text { get; set; }
        public string? FileName { get; set; }
        public byte[]? FileContent { get; set; }
    }
}
