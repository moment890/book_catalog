using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
    public class Categories_Books 
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public List<Genre_Books> Genres_Books { get; set; } = new List<Genre_Books>();
    }
}
