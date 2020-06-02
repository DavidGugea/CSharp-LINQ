using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeGroups = from employee in Employee.GetAllEmployees()
                                 group employee by employee.Department into eGroup
                                 orderby eGroup.Key
                                 select new
                                 {
                                     Key = eGroup.Key,
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };
            
            foreach(var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
                Console.WriteLine("---------------------");

                foreach(var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }

                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine();
                }
            }
            
            Console.ReadKey();
        }
    }
}
