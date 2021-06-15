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
using LibraryDAL;


namespace LibraryDAL
{
    public class EmployeeDao : Base
    {
        public List<Employee> GetAllEmployees() 
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select  EmployeeID,firstname, lastname, Emp_Password from Employee ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = ReadEmployee(reader);
                employees.Add(employee);
            }
            reader.Close();
            conn.Close();
            return employees;
        }
        public Employee GetEmployee(string name , int pass) 
        {
            SqlCommand cmd = new SqlCommand("select  EmployeeID,firstname, lastname, Emp_Password from Employee where Emp_Password = @pass and firstname = @name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", pass);       
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read()) 
            {
                 employee = ReadEmployee(reader);
            }
            conn.Close();
            reader.Close();
            return employee;
        }
        public Employee ReadEmployee(SqlDataReader reader) 
        {
            Employee employee = new Employee()
            {
                EmployeeID =(int)reader["EmployeeID"],
                firstname = (string)reader["firstname"],
                lasttname = (string)reader["lastname"],
                password = (int)reader["Emp_Password"],
            };
            return employee;
        }
    }
}
