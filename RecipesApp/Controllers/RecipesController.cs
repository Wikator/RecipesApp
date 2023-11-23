using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Extensions;
using RecipesApp.Helpers;
using RecipesApp.Shared.DTOs.Recipe;
using RecipesApp.Shared.Interfaces;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecipesController(IRecipeService recipeService) : ControllerBase
    {
        private IRecipeService RecipeService { get; } = recipeService;

        // GET: api/recipes?pageNumber=1&pageSize=5
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery] PaginationParams paginationParams)
        {       
            if (paginationParams.PageNumber is null || paginationParams.PageSize is null)
            {
                var recipes = await RecipeService.GetAllAsync(paginationParams.OrderBy, paginationParams.Filter);
                return Ok(recipes);
            }

            var paginatedRecipes = await RecipeService
                .GetPagedItemsAsync(paginationParams.PageNumber.Value, paginationParams.PageSize.Value,
                    paginationParams.OrderBy, paginationParams.Filter);

            Response.AddPaginationHeader(paginatedRecipes.PageNumber, paginatedRecipes.PageSize,
                paginatedRecipes.TotalCount, paginatedRecipes.TotalPages);

            return Ok(paginatedRecipes);
        }

        // GET api/recipes/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var recipe = await RecipeService.GetByIdAsync(id);

            if (recipe.Result is null)
                return NotFound(recipe.Result);

            return Ok(recipe.Result);
        }

        // POST api/recipes
        [HttpPost]
        public async Task<IActionResult> Post(RecipeCreateDto recipeDto)
        {
            var recipe = await RecipeService.AddAsync(recipeDto);

            return recipe.StatusCode switch
            {
                HttpStatusCode.Created => CreatedAtAction(nameof(Get), new { id = recipe.Result!.Id }, recipe.Result!),
                HttpStatusCode.Unauthorized => BadRequest(recipe.Message),
                HttpStatusCode.BadRequest => BadRequest(recipe.Message),
                _ => throw new Exception()
            };
        }

        // PUT api/recipes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RecipeUpdateDto recipeDto)
        {
            var result = await RecipeService.UpdateAsync(id, recipeDto);

            return result.StatusCode switch
            {
                HttpStatusCode.NoContent => NoContent(),
                HttpStatusCode.Unauthorized => Unauthorized(result.Message),
                HttpStatusCode.NotFound => NotFound(result.Message),
                _ => throw new Exception()
            };
        }

        // DELETE api/recipes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await RecipeService.DeleteAsync(id);

            return result.StatusCode switch
            {
                HttpStatusCode.NoContent => NoContent(),
                HttpStatusCode.Unauthorized => Unauthorized(result.Message),
                HttpStatusCode.NotFound => NotFound(result.Message),
                HttpStatusCode.BadRequest => BadRequest(result.Message),
                _ => throw new Exception()
            };
        }
    }
}
