using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin_testTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = Employee.GetAllEmployees().Join(Department.GetAllDepartments(), e => e.ID, d => d.ID,
                    (employee, department) => new
                    {
                        EmployeeName = employee.firstName,
                        DepartmentName = department.name
                    }
            ).GroupBy(joinItem => joinItem.DepartmentName);

            foreach(var item in expr)
            {
                Console.WriteLine("---------------------------  {0}  --------------------------", item.Key);

                foreach(var secondary_item in item)
                {
                    Console.WriteLine(secondary_item.EmployeeName);
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
