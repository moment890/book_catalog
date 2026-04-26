using book_catalog.Models;
using Microsoft.EntityFrameworkCore;


namespace book_catalog.Data {
    public class BookContext : DbContext
    {
        public DbSet<Categories_Books> categories_Books { get; set; }
        public DbSet<Genre_Books> genres_Books { get; set; }
        public DbSet<Title_Books> titles_Books { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
          //  optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=p511-890");
        }
    }
}
