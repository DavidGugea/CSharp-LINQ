using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Employee.GetAllEmployees().Join(
                    Department.GetAllDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (matchingEmployee, matchingDepartment) => new
                    {
                        // Return an anonymous class with the matching employee & the matching department that have the same ID ( DepartmentID == ID )
                        matchE = matchingEmployee,
                        matchD = matchingDepartment
                    }).GroupBy(r => r.matchD);

            foreach(var item in result)
            {
                Console.WriteLine(item.Key.Name);
                
                foreach(var secondary_item in item)
                {
                    Console.WriteLine(string.Format(" {0} ( {1} years old | ID : {2} | Department ID : {3} )",
                        secondary_item.matchE.Name,
                        secondary_item.matchE.Age,
                        secondary_item.matchE.ID,
                        secondary_item.matchE.DepartmentID
                    ));
                }

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                }
            }


            Console.ReadKey();
        }
    }
}
