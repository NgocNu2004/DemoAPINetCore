using DemoAPINetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPINetCore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optional: Seed data
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book A", Description = "Description of Book A", Price = 19.99, Quantity = 10 },
                new Book { Id = 2, Title = "Book B", Description = "Description of Book B", Price = 29.99, Quantity = 15 }
                // Add more books as needed
            );
        }
    }
}
