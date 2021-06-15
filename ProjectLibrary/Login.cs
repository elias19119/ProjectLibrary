using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModel;
using LibraryLogic;

namespace ProjectLibrary
{
    public partial class Login : Form
    {
        EmployeeServices employeeServices = new EmployeeServices();
        public Login()
        {
            InitializeComponent();
            Displayusers();
        }

        private void cmbboxusername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = cmbboxusername.SelectedItem as Employee;
        }
        private void Displayusers( ) 
        {
            cmbboxusername.Items.Clear();
            foreach (Employee emp in employeeServices.GetAllEmployees())
            {
                cmbboxusername.Items.Add(emp.ToString());
            }
          // cmbboxusername.SelectedIndex = 0; // select first customer
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = cmbboxusername.Text;
            bool correctPass = int.TryParse(txtpassword.Text, out int LoginPassword);

            if (correctPass)
            {
                Employee user = employeeServices.GetEmployee(userName,LoginPassword);

                if (user != null)
                {
                    Form1 Libraryoverview = new Form1(this, user);
                    Hide();
                    Libraryoverview.Show();
                }
                else
                    MessageBox.Show("You have entered a wrong password");
            }
            else
            {
                MessageBox.Show("Please enter the password in the correct format.");
            }
        }
    }
}
