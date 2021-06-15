using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogic;
using LibraryModel;

namespace ProjectLibrary
{
    public partial class Book_Overview : Form
    {
        BookServices bookservices = new BookServices();
        Form Previousform;
        public Book_Overview(Form previous)
        {
            this.Previousform = previous;
            InitializeComponent();
        }

        private void panelEditbutton_Click(object sender, EventArgs e)
        {
            Book book = fillEditbook();

            string message = $"Are you sure you want to edit the Book  {book.Title}?";
            string header = "Edit Book!";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                bookservices.EditBook(book);
                MessageBox.Show("Employee is edited!");
            }
            displayAllBooks();
        }
        private Book fillEditbook()
        {
            Book book = new Book()
            {
                Author = txtautheditbook.Text,
                Title = txttitleeditbook.Text,
                Price = Convert.ToDecimal(txtprieditbook.Text),
                Available = Convert.ToBoolean(txtavaieditbook.Text),
                Days_Rented = Convert.ToInt32(txtrenteditbook.Text),
                BookID = Convert.ToInt32(txtbookeditbook.Text),
                Category = (Category)(Convert.ToInt32(txtcateeditbook.Text)),
            };
            return book;
        }
        private void displayAllBooks() 
        {
            List<Book> books = bookservices.GetAllBooks();

            ListBook.Items.Clear();

            foreach (Book book in books)
            {
                ListViewItem li = new ListViewItem(book.BookID.ToString());
                li.SubItems.Add(book.Title);
                li.SubItems.Add(book.Author);
                li.SubItems.Add(book.Price.ToString());
                li.SubItems.Add(book.Available.ToString());
                li.SubItems.Add(book.Category.ToString());
                li.SubItems.Add(book.Days_Rented.ToString());
                li.Tag = book;
                ListBook.Items.Add(li);
            }

        }

        private void Book_Overview_Load(object sender, EventArgs e)
        {
            displayAllBooks();
            panAddBook.Visible = false;
            paneditbook.Visible = false;
        }

        private void btnbacktopre_Click(object sender, EventArgs e)
        {
            Previousform.Show();
            this.Close();
        }

        private void paneladdbutton_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookID = Convert.ToInt32(txtbookidadd.Text),
                Author = txtauthor.Text,
                Title = txttitle.Text,
                Price = Convert.ToDecimal(txtprice.Text),
                Available = Convert.ToBoolean(txtava.Text),
                Days_Rented = Convert.ToInt32(txtrent.Text),
                Category = (Category)(Convert.ToInt32(txtcate.Text)),
            };
            string message = $"Do you want to Add {book.Title}?";
            string header = "Add Employee";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                bookservices.InsertBook(book);
                MessageBox.Show("book is added!");
            }
            displayAllBooks();
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            panAddBook.Visible = true;
            paneditbook.Visible = false;
        }

        private void btneditbook_Click(object sender, EventArgs e)
        {
            paneditbook.Visible = true;
            panAddBook.Visible = false;
        }
    }
}
