using book_catalog.Models;
using Microsoft.EntityFrameworkCore;


namespace book_catalog.Data {
    public class BookContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=p511-890");
        }
    }
}
