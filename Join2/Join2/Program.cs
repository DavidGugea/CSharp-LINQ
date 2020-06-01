using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var result = Department.GetAllDepartments().GroupJoin(
                Employee.GetAllEmployees(),
                d => d.ID,
                e => e.DepartmentID,
                (department, collectionEmployees) => new
                {
                    department,
                    collectionEmployees
                }
            );
            */

            /*
            var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         select new
                         {
                             department = d,
                             collectionEmployees = eGroup
                         };
            */

            var result = Employee.GetAllEmployees().Join(
                    Department.GetAllDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (matchE, matchD) => new
                    {
                        employee = matchE,
                        department = matchD
                    }).GroupBy(r => r.department);

            foreach(var item in result)
            {
                Console.WriteLine(item.Key.Name);
                
                foreach(var group in item)
                {
                    Console.WriteLine(" " + group.employee.Name);
                }

                Console.WriteLine();
            }

            /*
            foreach(var item in result)
            {
                Console.WriteLine(item.employee.Name + "\t" + item.department.Name);
            }
            */

            /*
            foreach(var item in result)
            {
                Console.WriteLine(string.Format("{0} [ {1} ]", item.department.Name, item.department.ID));
                
                foreach(var employee in item.collectionEmployees)
                {
                    Console.WriteLine(" " + employee.Name);
                }

                Console.WriteLine();
            }
            */

            Console.ReadKey();
        }
    }
}
