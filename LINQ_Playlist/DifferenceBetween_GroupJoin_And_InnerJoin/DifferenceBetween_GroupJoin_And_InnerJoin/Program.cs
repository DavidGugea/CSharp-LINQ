using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetween_GroupJoin_And_InnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new { e, d };

            foreach(var employee in result)
            {
                Console.WriteLine(employee.e.Name + "\t" + employee.d.Name);
            }

            Console.ReadKey();
        }
    }
}