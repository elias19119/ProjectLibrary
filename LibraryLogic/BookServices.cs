using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModel;

namespace LibraryLogic
{
    public class BookServices
    {
        BookDao BookDao = new BookDao();
        public List<Book> GetAllBooks()
        {
          //  try
           // {
                return BookDao.GetAllBooks();
           // }
            //catch (Exception)
            //{
            //    return null;
            //}
          
        }
        public void UpdateBookStatus(Book book) 
        {
            BookDao.UpdateBookStatus(book);
        }
        public void UpdateBookStatusToFalse(Book book) 
        {
            BookDao.UpdateBookStatusToFalse(book);
        }
        public List<Book> SearchByPublisher(string name)
        {
            return BookDao.SearchByPublisher(name);
        }
        public List<Book> SearchByAuthor(string name) 
        {
            return BookDao.SearchByAuthor(name);
        }
        public void InsertBook(Book book)
        {
             BookDao.InsertBook(book);
           
        }
        public void EditBook(Book book)
        {
           
                BookDao.EditBook(book);
          
        }
        public int GetNumberofbooks()
        {
            //try 
            //{
                return BookDao.GetNumberofbooks();
            //}

            //catch (Exception)
            //{
            //    return -1;
            //}
        }
        public decimal GetTotalPrice()
        {
            return BookDao.GetTotalPrice();
        }
        public int GetAllAvailableBooks()
        {
            return BookDao.GetAllAvailableBooks();
        }
    }
}
