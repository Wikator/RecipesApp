using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Entities;

namespace RecipesApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RecipeReview> RecipeReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                 .HasIndex(u => u.NormalizedEmail)
                 .IsUnique();

            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Picture)
                .WithOne(p => p.Recipe)
                .HasForeignKey<Picture>(p => p.RecipeId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Comments)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
