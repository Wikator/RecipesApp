using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Entities;

namespace RecipesApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Picture)
                .WithOne(p => p.Recipe)
                .HasForeignKey<Picture>(p => p.RecipeId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Comments)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);

            for (int i = 1; i <= 500; i++)
            {
                modelBuilder.Entity<Recipe>().HasData(
                    new Recipe
                    {
                        Id = i,
                        Name = $"Sample Recipe {i}",
                        Text = $"This is the text for Sample Recipe {i}.",
                        AuthorId = "23bd91c2-6d78-4c12-8b66-be229116d90e",
                        PictureId = i
                    });

                modelBuilder.Entity<Picture>().HasData(
                    new Picture
                    {
                        Id = i,
                        RecipeId = i,
                        PublicId = "ra-net8/fv76pvmxfr279a34unbm",
                        Url = "https://res.cloudinary.com/dixigtgdo/image/upload/v1700323386/ra-net8/fv76pvmxfr279a34unbm.webp"
                    });

                modelBuilder.Entity<Comment>().HasData(
                    new Comment
                    {
                        Id = i,
                        Text = "Cool!",
                        AuthorId = "23bd91c2-6d78-4c12-8b66-be229116d90e",
                        RecipeId = i
                    });
            }
        }
    }
}
