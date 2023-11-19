using RecipesApp.Data;

namespace RecipesApp.Entities
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required string? AuthorId { get; set; }
        public ApplicationUser? Author { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
