using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var result = Employee.GetAllEmployees()
                .Join(Department.GetAllDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (employee, department) =>
                    new
                    {
                        EmployeeName = employee.Name,
                        DepartmentName = department.Name
                    }
                );
            */

            /*
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.Name
                         };
            */

            var result = Employee.GetAllEmployees()
                .Join(Department.GetAllDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (employee, department) => new
                    {
                        EmployeeName = employee.Name,
                        DepartmentName = department.Name
                    }
            );
                
            foreach(var employee in result)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
            }
            


            Console.ReadKey();
        }
    }
}
