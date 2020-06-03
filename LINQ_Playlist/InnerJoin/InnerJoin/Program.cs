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
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.Name
                         };

            foreach(var employee in result)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
            }

            Console.ReadKey();
        }
    }
}