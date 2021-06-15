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
    public partial class Form1 : Form
    {
        Form login;
        private Employee employee;
        BookServices BookServices = new BookServices();
        MemberServices memberServices = new MemberServices();
        
        public Form1(Form login , Employee employee )
        {
            this.login = login;
            this.employee = employee;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotalBooks.Text = BookServices.GetNumberofbooks().ToString();
            lblTotalMembers.Text = memberServices.GetNumberofMembers().ToString();
            lblTotalPrice.Text = BookServices.GetTotalPrice().ToString();
            lblAvailablebooks.Text = BookServices.GetAllAvailableBooks().ToString();
            lblCurrentemp.Text = employee.firstname;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options options = new Options(this);
            options.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }
    }
}
