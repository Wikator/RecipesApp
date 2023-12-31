﻿using RecipesApp.Shared.DTOs.ApplicationUser;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.DTOs.Ingredient;

namespace RecipesApp.Shared.DTOs.Recipe
{
    public class RecipeReadOnlyDetailsDto
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public string? Text { get; init; }
        public string? ImageUrl { get; init; }
        public required ApplicationUserReadOnlyDto Author { get; init; }
        public List<CommentReadOnlyDto> Comments { get; init; } = [];
        public List<IngredientReadOnlyDto> Ingredients { get; init; } = [];
        public int? UserReview { get; set; }
    }
}
