namespace RecipesApp.Shared.DTOs.Comment
{
    public class CommentReadOnlyDto
    {
        public int Id { get; init; }
        public required string Text { get; init; }
        public string? Author { get; init; }
    }
}
