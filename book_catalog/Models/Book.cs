using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models 
{
    [Table("books")]
    public class Book 
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("year")]
        public int Year { get; set; }

        // Внешние ключи
        [Column("categoryid")]
        public int CategoryId { get; set; }
        [Column("genreid")]
        public int GenreId { get; set; }

        // Навигационные свойства

        public Category Category { get; set; }
        public Genre Genre { get; set; }
    }
}
