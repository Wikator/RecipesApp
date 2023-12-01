namespace RecipesApp.Tests
{
    public class RecipesControllerTests
    {
        // [Fact]
        // public async Task Get_Returns_OkResult_With_PagedRecipes()
        // {
        //     // Arrange
        //     var recipeServiceMock = new Mock<IRecipeService>();
        //     recipeServiceMock.Setup(x => x.GetPagedItemsAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(
        //         new PagedList<RecipeReadOnlyDto>(new List<RecipeReadOnlyDto>{
        //             new()
        //             {
        //                 Id = 1,
        //                 Name = "Test Recipe",
        //                 Author = "User 1"
        //             }
        //         }, 1, 5, 5));
        //
        //     var controller = new RecipesController(recipeServiceMock.Object);
        //
        //     // Act
        //     var result = await controller.Get(new PaginationParams { PageNumber = 1, PageSize = 5 });
        //
        //     // Assert
        //     Assert.IsType<OkObjectResult>(result);
        // }

        [Fact]
        public async Task Get_ById_Returns_OkResult_With_Recipe()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult<RecipeReadOnlyDetailsDto>
                {
                    Data = new RecipeReadOnlyDetailsDto
                    {
                        Id = 1,
                        Name = "Test Recipe",
                        Author = new ApplicationUserReadOnlyDto
                        {
                            UserName = "User 1"
                        }
                    },
                    StatusCode = HttpStatusCode.NoContent
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task Get_ById_Returns_NotFoundResult_When_Recipe_Not_Found()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult<RecipeReadOnlyDetailsDto> { Data = null, StatusCode = HttpStatusCode.NotFound });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task Post_Returns_CreatedAtActionResult_With_Recipe()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.AddAsync(It.IsAny<RecipeCreateDto>())).ReturnsAsync(
                new ServiceResult<RecipeReadOnlyDetailsDto>
                {
                    StatusCode = HttpStatusCode.Created,
                    Data = new RecipeReadOnlyDetailsDto
                    {
                        Id = 1,
                        Name = "Test Recipe",
                        Author = new ApplicationUserReadOnlyDto
                        {
                            UserName = "User 1"
                        }
                    }
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Post(new RecipeCreateDto { Name = "Test Recipe" });

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public async Task Put_Returns_NoContentResult()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.UpdateAsync(It.IsAny<int>(), It.IsAny<RecipeUpdateDto>())).ReturnsAsync(
                new ServiceResult { StatusCode = HttpStatusCode.NoContent });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Put(1, new RecipeUpdateDto { Name = "Updated Recipe" });

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_Returns_NoContentResult()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult { StatusCode = HttpStatusCode.NoContent });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Post_Returns_BadRequestResult_When_Service_Returns_BadRequest()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.AddAsync(It.IsAny<RecipeCreateDto>())).ReturnsAsync(
                new ServiceResult<RecipeReadOnlyDetailsDto>
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Post(new RecipeCreateDto { Name = "Invalid Recipe" });

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task Put_Returns_UnauthorizedResult_When_Service_Returns_Unauthorized()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.UpdateAsync(It.IsAny<int>(), It.IsAny<RecipeUpdateDto>())).ReturnsAsync(
                new ServiceResult
                {
                    StatusCode = HttpStatusCode.Unauthorized,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Put(1, new RecipeUpdateDto { Name = "Invalid Recipe" });

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(result);
        }

        [Fact]
        public async Task Put_Returns_NotFoundResult_When_Service_Returns_NotFound()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.UpdateAsync(It.IsAny<int>(), It.IsAny<RecipeUpdateDto>())).ReturnsAsync(
                new ServiceResult
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Put(1, new RecipeUpdateDto { Name = "Invalid Recipe" });

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task Delete_Returns_BadRequestResult_When_Service_Returns_BadRequest()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task Delete_Returns_UnauthorizedResult_When_Service_Returns_Unauthorized()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult
                {
                    StatusCode = HttpStatusCode.Unauthorized,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(result);
        }

        [Fact]
        public async Task Delete_Returns_NotFoundResult_When_Service_Returns_NotFoundResult()
        {
            // Arrange
            var recipeServiceMock = new Mock<IRecipeService>();
            recipeServiceMock.Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(
                new ServiceResult
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "Validation error"
                });

            var controller = new RecipesController(recipeServiceMock.Object);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}
