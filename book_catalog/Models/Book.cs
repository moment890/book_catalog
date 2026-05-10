using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
    public class Book 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        // Внешние ключи
        public int CategoryId { get; set; }
        public int GenreId { get; set; }

        // Навигационные свойства
        public Category Category { get; set; }
        public Genre Genre { get; set; }
    }
}
