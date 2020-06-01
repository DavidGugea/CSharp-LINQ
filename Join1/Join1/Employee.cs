using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public long ID { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Name = "Employee01", Age = 20, ID = 1, DepartmentID = 1 },
                new Employee { Name = "Employee02", Age = 25, ID = 2, DepartmentID = 2 },
                new Employee { Name = "Employee03", Age = 30, ID = 3, DepartmentID = 1 },
                new Employee { Name = "Employee04", Age = 35, ID = 4, DepartmentID = 2 },
                new Employee { Name = "Employee05", Age = 22, ID = 5, DepartmentID = 1 },
                new Employee { Name = "Employee06", Age = 27, ID = 6, DepartmentID = 2 },
                new Employee { Name = "Employee07", Age = 28, ID = 7, DepartmentID = 1 },
                new Employee { Name = "Employee08", Age = 32, ID = 8, DepartmentID = 2 },
                new Employee { Name = "Employee09", Age = 37, ID = 9, DepartmentID = 1 },
                new Employee { Name = "Employee10", Age = 39, ID = 10, DepartmentID = 2 }
            };
        }
    }
}
