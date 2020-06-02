using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_MultipleKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeGroups = from employee in Employee.GetAllEmployees()
                                 group employee by new { employee.Department, employee.Gender } into eGroup
                                 orderby eGroup.Key.Department, eGroup.Key.Gender
                                 select new
                                 {
                                     Dept = eGroup.Key.Department,
                                     Gender = eGroup.Key.Gender,
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };

            foreach(var group in employeeGroups)
            {
                Console.WriteLine(string.Format("{0} department {1} employees count = {2}", 
                    group.Dept,
                    group.Gender,
                    group.Employees.Count()
                ));
                Console.WriteLine("-----------------------------------------------");

                foreach(var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
