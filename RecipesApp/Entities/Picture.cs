using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesApp.Entities
{
    [Table("Pictures")]
    public class Picture
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public required string PublicId { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
