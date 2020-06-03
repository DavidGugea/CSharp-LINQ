using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = from d in Department.GetAllDepartments()
                                        join e in Employee.GetAllEmployees()
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employees = eGroup
                                        };

            foreach(var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);

                foreach(var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
