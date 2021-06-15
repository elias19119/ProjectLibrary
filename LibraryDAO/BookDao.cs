using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;
using LibraryModel;

namespace LibraryDAL
{
    public class BookDao : Base
    {

        public List<Book> GetAllBooks()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Book_ID,Author,Title,Price,Available,Days_Rented,CategoryID,Pub_ID FROM Books ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = GetBook(reader);
                books.Add(book);
            }
            reader.Close();
            conn.Close();
            return books;
        }
        private Book GetBook(SqlDataReader reader) 
        {
            Book book = new Book()
            {            
                publisher = new Publisher((int)reader["Pub_ID"]),
                Author = (string)reader["Author"],
                Title = (string)reader["Title"],
                Available = (bool)reader["Available"],
                Days_Rented = (int)reader["Days_Rented"],
                Price = (decimal)reader["Price"],
                Category = (Category)reader["CategoryID"],
                BookID = (int)reader["Book_ID"],
            };
            return book;
        }
        private Book ReadBook(SqlDataReader reader)
        {

            Book book = new Book()
            {

                Author = (string)reader["Author"],
                Title = (string)reader["Title"],
                Available = (bool)reader["Available"],
                Days_Rented = (int)reader["Days_Rented"],
                Price = (decimal)reader["Price"],
                Category = (Category)reader["CategoryID"],
                BookID = (int)reader["Book_ID"],
            };

            book.publisher.PubID = (int)reader["pub_id"];
            book.publisher.Name = (string)reader["pub_name"];
            book.publisher.Address = (string)reader["pub_address"];
            book.publisher.Telephonenum = (int)reader["telephonenum"];
            return book;
        }
        public List<Book> SearchByPublisher(string name)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Books.Book_ID, books.Days_Rented, publisher.pub_name, books.price, books.categoryid, books.author, publisher.pub_id, books.available, Books.Title, Publisher.Pub_Address,Publisher.Telephonenum  FROM Books join Publishe on Books.Book_ID = Publishe.Book_ID Join Publisher on Publishe.Pub_ID = Publisher.Pub_ID WHERE Publisher.Pub_Name = @Publishername", conn);
            cmd.Parameters.AddWithValue("@Publishername", name);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {

                Book b = ReadBook(reader);
                books.Add(b);
            }
            reader.Close();
            conn.Close();
            return books;
        }
        public List<Book> SearchByAuthor(string name)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Books.Book_ID, books.Days_Rented, publisher.pub_name, books.price, books.categoryid, books.author, publisher.pub_id, books.available, Books.Title, Publisher.Pub_Address,Publisher.Telephonenum  FROM Books join Publishe on Books.Book_ID = Publishe.Book_ID Join Publisher on Publishe.Pub_ID = Publisher.Pub_ID WHERE books.Author = @bookauthor", conn);
            cmd.Parameters.AddWithValue("@bookauthor", name);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book b = ReadBook(reader);
                books.Add(b);
            }
            reader.Close();
            conn.Close();
            return books;
        }
        public void InsertBook(Book book)
        {
            int category = (int)book.Category;
            string query = $"insert into Books(Book_ID,Author,Title,Price,Available,Days_Rented,CategoryID) " +
                $"values('{book.BookID}','{book.Author}', '{book.Title}', '{book.Price}', {(book.Available ? "1" : "0")}, {book.Days_Rented}, {category})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void EditBook(Book book)
        {
            string query = $"update Books Set Author = '{book.Author}', Title = '{book.Title}'," +
               $"Price = '{book.Price}', Available = '{(book.Available ? "1" : "0")}', Days_Rented = {book.Days_Rented},CategoryID = {Convert.ToInt32(book.Category)} WHERE Book_ID = {book.BookID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetNumberofbooks()
        {
            int numberofbooks = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) AS count  FROM Books", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numberofbooks = (int)reader["count"];
            }
            conn.Close();
            return numberofbooks;
        }
        public decimal GetTotalPrice()
        {
            decimal numberofbooks = 0.0m;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Price) AS total FROM Books", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numberofbooks = (decimal)reader["total"];
            }
            conn.Close();
            return numberofbooks;
        }
        public int GetAllAvailableBooks()
        {
            int numberofbooks = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) AS count FROM Books WHERE Available =1", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numberofbooks = (int)reader["count"];
            }
            conn.Close();
            return numberofbooks;
        }
        public void UpdateBookStatus(Book book)
        {
            SqlCommand cmd = new SqlCommand("SET ROWCOUNT 1 UPDATE Books SET Available = 1 WHERE Book_ID = @Bookid ;SET ROWCOUNT 0", conn);
            cmd.Parameters.AddWithValue("@Bookid", book.BookID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateBookStatusToFalse(Book book)
        {
            SqlCommand cmd = new SqlCommand("SET ROWCOUNT 1 UPDATE Books SET Available = 0 WHERE Book_ID = @Bookid ;SET ROWCOUNT 0", conn);
            cmd.Parameters.AddWithValue("@Bookid", book.BookID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
