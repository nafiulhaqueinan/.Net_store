using Microsoft.EntityFrameworkCore;
using Test_store.Models;

namespace Test_store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {


            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Description = "Action movies" },
                new Category { Id = 2, Name = "Comedy", Description = "Comedy movies" },    
                new Category { Id = 3, Name = "Drama", Description = "Drama movies" },
                new Category { Id = 4, Name = "Horror", Description = "Horror movies" },
                new Category { Id = 5, Name = "Romance", Description = "Romance movies" }
                );
        }
    }
}
