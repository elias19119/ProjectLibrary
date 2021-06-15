using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public class Book
    {

        public Book()
        {
            publisher = new Publisher();
        }
        public Book(int bookid)
        {
            BookID = bookid;
            publisher = new Publisher();
        }

        public Publisher publisher { get; set; }
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public bool Available { get; set; }
        public int Days_Rented { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        

    }
}
