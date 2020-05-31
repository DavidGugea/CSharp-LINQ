using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenGroupJoinAndInnerJoin
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
                             e,
                             d
                         };

            foreach(var employee in result)
            {
                Console.WriteLine(employee.e.Name + "\t" + employee.d.Name);
            }

            /*
            var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         select new
                         {
                             Department = d,
                             Employees = eGroup
                         };

            foreach(var department in result)
            {
                Console.WriteLine(department.Department.Name);
                foreach(var employee in department.Employees)
                {
                    Console.WriteLine(string.Format(" {0}", employee.Name));
                }

                Console.WriteLine();
            }
            */

            Console.ReadKey();
        }
    }
}
