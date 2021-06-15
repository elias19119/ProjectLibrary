using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModel;

namespace LibraryLogic
{
    public class EmployeeServices
    {
        EmployeeDao EmployeeDao = new EmployeeDao();
        public List<Employee> GetAllEmployees()
        {
            return EmployeeDao.GetAllEmployees(); ;
        }
        public Employee GetEmployee(string name, int pass) 
        {
            return EmployeeDao.GetEmployee(name,pass);
        }
    }
}
