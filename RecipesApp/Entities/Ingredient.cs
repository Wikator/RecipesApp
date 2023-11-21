using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesApp.Entities
{
    [Table("Ingredients")]
    public class Ingredient
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Amount { get; set; }
        public string? Notes { get; set; }

        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
