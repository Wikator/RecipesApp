using Microsoft.AspNetCore.Mvc;
using Moq;
using RecipesApp.Controllers;
using RecipesApp.Shared.DTOs.Comment;
using RecipesApp.Shared.Helpers;
using RecipesApp.Shared.Interfaces;
using System.Net;

namespace RecipeApp.Tests
{
    public class CommentControllerTests
    {
        [Fact]
        public async Task Get_Returns_OkResult_With_Comments()
        {
            // Arrange
            var commentServiceMock = new Mock<ICommentService>();
            commentServiceMock.Setup(x => x.GetComments(It.IsAny<int>()))
                .ReturnsAsync(new ServiceResult<IEnumerable<CommentReadOnlyDto>>
                {
                    Result = new List<CommentReadOnlyDto>
                    {
                        new CommentReadOnlyDto
                        {
                            Id = 1,
                            Text = "Test Comment",
                        }
                    },
                    IsSuccessful = true,
                    StatusCode = HttpStatusCode.OK
                });

            var controller = new CommentsController(commentServiceMock.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task Post_Returns_CreatedAtActionResult_With_Comment()
        {
            // Arrange
            var commentServiceMock = new Mock<ICommentService>();
            commentServiceMock.Setup(x => x.AddComment(It.IsAny<CommentUpsertDto>()))
                .ReturnsAsync(new ServiceResult<CommentReadOnlyDto>
                {
                    Result = new CommentReadOnlyDto
                    {
                        Id = 1,
                        Text = "Test Comment"
                    },
                    StatusCode = HttpStatusCode.Created
                });

            var controller = new CommentsController(commentServiceMock.Object);

            // Act
            var result = await controller.Post(new CommentUpsertDto { RecipeId = 1, Text = "Test Comment" });

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public async Task Put_Returns_NoContentResult()
        {
            // Arrange
            var commentServiceMock = new Mock<ICommentService>();
            commentServiceMock.Setup(x => x.UpdateComment(It.IsAny<int>(), It.IsAny<CommentUpsertDto>()))
                .ReturnsAsync(new ServiceResult { StatusCode = HttpStatusCode.NoContent });

            var controller = new CommentsController(commentServiceMock.Object);

            // Act
            var result = await controller.Put(1, new CommentUpsertDto { RecipeId = 1, Text = "Updated Comment" });

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_Returns_NoContentResult()
        {
            // Arrange
            var commentServiceMock = new Mock<ICommentService>();
            commentServiceMock.Setup(x => x.DeleteComment(It.IsAny<int>()))
                .ReturnsAsync(new ServiceResult { StatusCode = HttpStatusCode.NoContent });

            var controller = new CommentsController(commentServiceMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}
