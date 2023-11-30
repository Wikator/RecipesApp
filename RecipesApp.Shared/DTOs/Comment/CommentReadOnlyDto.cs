namespace RecipesApp.Shared.DTOs.Comment
{
    public class CommentReadOnlyDto
    {
        public int Id { get; init; }
        public required string Text { get; set; }
        public string? Author { get; init; }
    }
}
