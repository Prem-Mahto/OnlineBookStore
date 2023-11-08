using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = 1, GenreName = "Magazine" },
                new Genre { GenreID = 2, GenreName = "Self-help" },
                new Genre { GenreID = 3, GenreName = "Romantic" },
                new Genre { GenreID = 4, GenreName = "Mystery" },
                new Genre { GenreID = 5, GenreName = "Lierature" }
                );
            modelBuilder.Entity<Book>().HasData(
               new Book { BookID = 1, Title = "Autocar India Oct 2023 Magazine", Author = "Autocar", CoverImage = "/images/magazine/autocar-india-oct-2023.webp", Description = "Autocar India Oct 2023 Magazine", PublicationDate = DateTime.Parse("01-10-2023"), ISBN = "101", Price = 100, Quantity = 1, GenreID = 1 },
               new Book { BookID = 2, Title = "World 360 Magazine", Author = "World 360", CoverImage = "/images/magazine/world-360-original.webp", Description = "World 360 Magazine", PublicationDate = DateTime.Parse("01-09-2023"), ISBN = "102", Price = 100, Quantity = 2, GenreID = 1 },
               new Book { BookID = 3, Title = "Dubai Magazine", Author = "Dubai", CoverImage = "/images/magazine/dubai-original.webp", Description = "Dubai Magazine", PublicationDate = DateTime.Parse("01-08-2023"), ISBN = "103", Price = 100, Quantity = 3, GenreID = 1 },
               new Book { BookID = 4, Title = "Galamour Era Magazine", Author = "Galamour Era", CoverImage = "/images/magazine/glamaour-era-original.webp", Description = "Galamour Era Magazine", PublicationDate = DateTime.Parse("01-07-2023"), ISBN = "104", Price = 100, Quantity = 4, GenreID = 1 },
               new Book { BookID = 5, Title = "Journal of Eco Friendly Agriculture Magazine", Author = "Agriculture Magazine", CoverImage = "/images/magazine/journal-of-eco-friendly-agriculture-original.webp", Description = "Galamour Era Magazine", PublicationDate = DateTime.Parse("01-06-2023"), ISBN = "105", Price = 100, Quantity = 5, GenreID = 1 },
               new Book { BookID = 6, Title = "Naruto Magazine", Author = "Naruto", CoverImage = "/images/magazine/naruto-vol-38-original.webp", Description = "Naruto Magazine", PublicationDate = DateTime.Parse("01-05-2023"), ISBN = "106", Price = 100, Quantity = 6, GenreID = 1 },
               new Book { BookID = 7, Title = "Organic Sunrise Magazine", Author = "Agriculture Magazine", CoverImage = "/images/magazine/organic-sunrise-natural-original.webp", Description = "Organic Sunrise Magazine Magazine", PublicationDate = DateTime.Parse("01-04-2023"), ISBN = "107", Price = 100, Quantity = 7, GenreID = 1 },
               new Book { BookID = 8, Title = "Pshycologs Magazine", Author = "Pshycologs", CoverImage = "/images/magazine/psychologs-magazine-september-2023-original.webp", Description = "Phycologs Magazine", PublicationDate = DateTime.Parse("01-03-2023"), ISBN = "108", Price = 100, Quantity = 8, GenreID = 1 }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
