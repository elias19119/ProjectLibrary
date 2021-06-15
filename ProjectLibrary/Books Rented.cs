using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryLogic;
using LibraryModel;

namespace ProjectLibrary
{
    public partial class Books_Rented : Form
    {
        Form passedform;
        BookServices BookServices;
        List<Book> books = new List<Book>();
        public Books_Rented(Form form)
        {
            BookServices = new BookServices();
            this.passedform = form;
            InitializeComponent();
        }
        private void Books_Rented_Load(object sender, EventArgs e)
        {
            displayBooks();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            passedform.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (listbooksrented.SelectedItems.Count > 0) 
            {               
                string message = $"Do you want to change this book status?";
                string header = $"Update";
                DialogResult result = MessageBox.Show(message, header, MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes) 
                {
                    displayBooks();
                }
            }
        }      
        private void displayBooks() 
        {
            books = BookServices.GetAllBooks();
            listbooksrented.Items.Clear();
            foreach (Book book in books)
            {
                ListViewItem list= new ListViewItem(book.BookID.ToString());
                list.SubItems.Add(book.publisher.PubID.ToString());
                list.SubItems.Add(book.Author);
                list.SubItems.Add(book.Title);
                list.SubItems.Add(book.Days_Rented.ToString());
                list.SubItems.Add(book.Category.ToString());
                list.SubItems.Add(book.Price.ToString());
                list.SubItems.Add(book.Available.ToString());
                list.Tag = book;
                listbooksrented.Items.Add(list);
            }
        }

        private void listbooksrented_MouseClick(object sender, MouseEventArgs e)
        {
            Book book = listbooksrented.SelectedItems[0].Tag as Book;
            string header = $"Update";
            DialogResult result = MessageBox.Show("Do You Want To Make a Book Available ?", header, MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes) 
            {
                
                BookServices.UpdateBookStatus(book);
            }
            else if(result == DialogResult.No) 
            {
                BookServices.UpdateBookStatusToFalse(book);
            }
        }
    }
}
