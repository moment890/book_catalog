using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
   public class Category 
    {
        
            public int Id { get; set; }
            public string Name { get; set; }

            // Навигационное свойство для связи с книгами
            public ICollection<Book> Books { get; set; } = new List<Book>();
        }
    }
}
