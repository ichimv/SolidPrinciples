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

    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
    public class DIPEmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // Hardcoded Employ values instead to read it from a dbase
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Ionescu",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
    public class DIPDataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new DIPEmployeeDataAccess();
        }
    }
    public class DIPEmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public DIPEmployeeBusinessLogic(IEmployeeDataAccess employeeDataAccess)
        {
            _EmployeeDataAccess = employeeDataAccess;
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
