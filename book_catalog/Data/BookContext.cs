using book_catalog.Models;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.EntityFrameworkCore;


namespace book_catalog.Data {
    public class BookContext : DbContext
    {
        public DbSet<Category> category { get; set; }
        public DbSet<Genr> genres_Books { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
          //  optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=p511-890");
        }
    }
}
