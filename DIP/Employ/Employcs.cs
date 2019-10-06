using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // Hardcoded Employ values instead to read it from a dbase
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Stefan",
                Department = "IT",
                Salary = 1500
            };
            return emp;
        }
    }

    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }

    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
