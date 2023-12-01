using System.ComponentModel.DataAnnotations;

namespace RecipesApp.Shared.DTOs.Recipe;

public class RecipeReviewUpsertDto
{
    [Range(1, 5)]
    public int Score { get; set; }
}