using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedRecipeReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeReview_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RecipeReview_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeReview_ApplicationUserId",
                table: "RecipeReview",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeReview_RecipeId",
                table: "RecipeReview",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeReview");
        }
    }
}
