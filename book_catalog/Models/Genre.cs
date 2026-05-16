using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
    [Table("genre")]
    public class Genre {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }


        // Навигационное свойство для связи с книгами
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
