using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_catalog.Models {
    public class Title_Books 
    {
     public int Book_Id { get; set; }
    public string Book_Title { get; set; }
    public int Genre_Id { get; set; }
    public Genre_Books Genre_Books { get; set; }
    }
}
