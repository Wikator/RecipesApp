using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.Interfaces;
using System.Net;

namespace RecipesApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CommentsController(ICommentService commentService) : ControllerBase
    {
        private ICommentService CommentService { get; } = commentService;

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id) 
        {
            var comments = (await CommentService.GetComments(id)).Result
                ?? throw new Exception("Comments not present, despite operation completing successfully");

            return Ok(comments);   
        }

        [HttpPost]
        public async Task<IActionResult> Post(CommentUpsertDto dto)
        {
            var comment = (await CommentService.AddComment(dto)).Result
                ?? throw new Exception("Comment not present, despite operation completing successfully");

            return CreatedAtAction(nameof(Get), new { id = dto.RecipeId}, comment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CommentUpsertDto dto)
        {
            var commentResult = await CommentService.UpdateComment(id, dto);

            return commentResult.StatusCode switch
            {
                HttpStatusCode.NoContent => NoContent(),
                HttpStatusCode.Unauthorized => Unauthorized(commentResult.Message),
                HttpStatusCode.NotFound => NotFound(commentResult.Message),
                _ => throw new Exception()
            };
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var commentResult = await CommentService.DeleteComment(id);

            return commentResult.StatusCode switch
            {
                HttpStatusCode.NoContent => NoContent(),
                HttpStatusCode.Unauthorized => Unauthorized(commentResult.Message),
                HttpStatusCode.NotFound => NotFound(commentResult.Message),
                _ => throw new Exception()
            };
        }
    }
}
