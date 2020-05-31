using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var employeeGroups = Employee.GetAllEmployees()
                .GroupBy(x => x.Department);
            */

            var employeeGroups = from employee in Employee.GetAllEmployees()
                                 group employee by employee.Department into eGroup
                                 orderby eGroup.Key
                                 select new
                                 {
                                     Key = eGroup.Key,
                                     Employees = eGroup.OrderBy(employee => employee.Name)
                                 };

            foreach(var group in employeeGroups)
            {
                Console.WriteLine(string.Format("{0} - {1}", group.Key, group.Employees.Count()));
                Console.WriteLine("-----------");
                foreach(var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }

                Console.WriteLine();
            }
             
            Console.ReadKey();
        }
    }
}
