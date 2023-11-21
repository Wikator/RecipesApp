namespace RecipesApp.Shared.DTOs.Ingredient
{
    public class IngredientReadOnlyDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Amount { get; set; }
        public string? Notes { get; set; }
    }
}
