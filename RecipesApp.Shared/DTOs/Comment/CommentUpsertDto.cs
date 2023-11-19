using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Shared.DTOs.Comment
{
    public class CommentUpsertDto
    {
        [Required]
        public string Text { get; set; } = string.Empty;
        public int RecipeId { get; set; }
    }
}
