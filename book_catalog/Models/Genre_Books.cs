using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
    public class Genre_Books 
    {
        public int Genre_Id { get; set; }
        public string Genre_Name { get; set; }
        public int Category_Id { get; set; }
        public Categories_Books Category { get; set; }
        public ICollection<Title_Books> Titles_Books { get; set; } = new List<Title_Books>();
    }
}
