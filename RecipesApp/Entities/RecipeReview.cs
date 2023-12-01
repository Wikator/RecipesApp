using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RecipesApp.Data;

namespace RecipesApp.Entities;

public class RecipeReview : IEntity
{
    public int Id { get; set; }
    
    [Range(1, 5)] public int Score { get; set; }

    public string? ApplicationUserId { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }

    public int RecipeId { get; set; }
    public Recipe? Recipe { get; set; }
}