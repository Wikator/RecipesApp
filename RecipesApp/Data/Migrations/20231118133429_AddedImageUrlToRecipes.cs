using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToRecipes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 101,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 102,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 103,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 104,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 105,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 106,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 107,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 108,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 109,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 110,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 111,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 112,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 113,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 114,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 115,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 116,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 117,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 118,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 119,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 120,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 121,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 122,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 123,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 124,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 125,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 126,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 127,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 128,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 129,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 130,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 131,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 132,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 133,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 134,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 135,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 136,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 137,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 138,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 139,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 140,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 141,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 142,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 143,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 144,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 145,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 146,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 147,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 148,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 149,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 150,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 151,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 152,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 153,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 154,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 155,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 156,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 157,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 158,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 159,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 160,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 161,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 162,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 163,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 164,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 165,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 166,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 167,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 168,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 169,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 170,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 171,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 172,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 173,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 174,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 175,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 176,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 177,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 178,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 179,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 180,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 181,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 182,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 183,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 184,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 185,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 186,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 187,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 188,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 189,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 190,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 191,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 192,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 193,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 194,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 195,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 196,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 197,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 198,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 199,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 200,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 201,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 202,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 203,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 204,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 205,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 206,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 207,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 208,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 209,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 210,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 211,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 212,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 213,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 214,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 215,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 216,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 217,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 218,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 219,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 220,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 221,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 222,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 223,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 224,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 225,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 226,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 227,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 228,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 229,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 230,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 231,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 232,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 233,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 234,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 235,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 236,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 237,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 238,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 239,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 240,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 241,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 242,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 243,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 244,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 245,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 246,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 247,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 248,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 249,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 250,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 251,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 252,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 253,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 254,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 255,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 256,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 257,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 258,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 259,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 260,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 261,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 262,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 263,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 264,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 265,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 266,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 267,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 268,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 269,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 270,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 271,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 272,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 273,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 274,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 275,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 276,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 277,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 278,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 279,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 280,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 281,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 282,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 283,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 284,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 285,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 286,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 287,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 288,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 289,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 290,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 291,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 292,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 293,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 294,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 295,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 296,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 297,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 298,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 299,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 300,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 301,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 302,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 303,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 304,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 305,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 306,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 307,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 308,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 309,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 310,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 311,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 312,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 313,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 314,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 315,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 316,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 317,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 318,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 319,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 320,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 321,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 322,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 323,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 324,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 325,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 326,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 327,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 328,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 329,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 330,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 331,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 332,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 333,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 334,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 335,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 336,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 337,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 338,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 339,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 340,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 341,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 342,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 343,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 344,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 345,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 346,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 347,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 348,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 349,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 350,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 351,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 352,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 353,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 354,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 355,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 356,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 357,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 358,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 359,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 360,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 361,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 362,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 363,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 364,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 365,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 366,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 367,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 368,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 369,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 370,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 371,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 372,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 373,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 374,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 375,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 376,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 377,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 378,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 379,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 380,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 381,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 382,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 383,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 384,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 385,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 386,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 387,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 388,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 389,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 390,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 391,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 392,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 393,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 394,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 395,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 396,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 397,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 398,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 399,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 400,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 401,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 402,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 403,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 404,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 405,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 406,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 407,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 408,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 409,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 410,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 411,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 412,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 413,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 414,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 415,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 416,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 417,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 418,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 419,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 420,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 421,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 422,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 423,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 424,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 425,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 426,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 427,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 428,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 429,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 430,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 431,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 432,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 433,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 434,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 435,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 436,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 437,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 438,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 439,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 440,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 441,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 442,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 443,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 444,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 445,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 446,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 447,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 448,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 449,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 450,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 451,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 452,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 453,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 454,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 455,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 456,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 457,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 458,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 459,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 460,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 461,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 462,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 463,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 464,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 465,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 466,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 467,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 468,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 469,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 470,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 471,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 472,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 473,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 474,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 475,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 476,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 477,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 478,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 479,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 480,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 481,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 482,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 483,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 484,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 485,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 486,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 487,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 488,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 489,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 490,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 491,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 492,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 493,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 494,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 495,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 496,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 497,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 498,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 499,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 500,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dixigtgdo/image/upload/v1683117861/cld-sample-4.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Recipes");
        }
    }
}
