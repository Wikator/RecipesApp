using RecipesApp.Data;

namespace RecipesApp.Entities
{
    public class Recipe : IEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Text { get; set; }

        public required string AuthorId { get; set; }

        public ApplicationUser? Author { get; set; }

        public int? PictureId { get; set; }
        public Picture? Picture { get; set; }

        public List<Comment>? Comments { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
    }
}
