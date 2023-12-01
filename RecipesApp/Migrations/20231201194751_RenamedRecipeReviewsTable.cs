using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesApp.Migrations
{
    /// <inheritdoc />
    public partial class RenamedRecipeReviewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeReview_AspNetUsers_ApplicationUserId",
                table: "RecipeReview");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeReview_Recipes_RecipeId",
                table: "RecipeReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeReview",
                table: "RecipeReview");

            migrationBuilder.RenameTable(
                name: "RecipeReview",
                newName: "RecipeReviews");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeReview_RecipeId",
                table: "RecipeReviews",
                newName: "IX_RecipeReviews_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeReview_ApplicationUserId",
                table: "RecipeReviews",
                newName: "IX_RecipeReviews_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeReviews",
                table: "RecipeReviews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeReviews_AspNetUsers_ApplicationUserId",
                table: "RecipeReviews",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeReviews_Recipes_RecipeId",
                table: "RecipeReviews",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeReviews_AspNetUsers_ApplicationUserId",
                table: "RecipeReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeReviews_Recipes_RecipeId",
                table: "RecipeReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeReviews",
                table: "RecipeReviews");

            migrationBuilder.RenameTable(
                name: "RecipeReviews",
                newName: "RecipeReview");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeReviews_RecipeId",
                table: "RecipeReview",
                newName: "IX_RecipeReview_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeReviews_ApplicationUserId",
                table: "RecipeReview",
                newName: "IX_RecipeReview_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeReview",
                table: "RecipeReview",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeReview_AspNetUsers_ApplicationUserId",
                table: "RecipeReview",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeReview_Recipes_RecipeId",
                table: "RecipeReview",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
