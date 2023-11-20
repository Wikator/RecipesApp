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
            await Task.Delay(500);
            
            if (paginationParams.PageNumber is null || paginationParams.PageSize is null)
            {
                return Ok((await RecipeService.GetAllAsync()).Result!);
            }

            var recipes = (await RecipeService
                .GetPagedItemsAsync(paginationParams.PageNumber.Value, paginationParams.PageSize.Value, paginationParams.OrderBy)).Result
                ?? throw new Exception("Recipes not present, despite operation completing successfully");

            Response.AddPaginationHeader(recipes.PageNumber, recipes.PageSize, recipes.TotalCount, recipes.TotalPages);
            return Ok(recipes);
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
        public async Task<IActionResult> Post(RecipeUpsertDto recipeDto)
        {
            var recipe = await RecipeService.AddAsync(recipeDto);

            switch (recipe.StatusCode)
            {
                case HttpStatusCode.Created:
                    var item = recipe.Result
                        ?? throw new Exception("Recipe not present, despite operation completing successfully");

                    return CreatedAtAction(nameof(Get), new { id =  item.Id }, item);

                case HttpStatusCode.BadRequest:
                    return BadRequest(recipe.Message);

                default: throw new Exception();
            }
        }

        // PUT api/recipes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RecipeUpsertDto recipeDto)
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
                HttpStatusCode.Unauthorized => BadRequest(result.Message),
                HttpStatusCode.NotFound => NotFound(result.Message),
                HttpStatusCode.BadRequest => BadRequest(result.Message),
                _ => throw new Exception()
            };
        }
    }
}
