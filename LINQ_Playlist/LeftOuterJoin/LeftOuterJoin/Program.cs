using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftOuterJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Employee.GetAllEmployees()
                .GroupJoin(
                    Department.GetAllDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (emp, depts) => new
                    {
                        emp,
                        depts
                    })
                .SelectMany(z => z.depts.DefaultIfEmpty(), (a, b) => new
                {
                    EmployeeName = a.emp.Name,
                    DepartmentName = b == null ? "No Department" : b.Name
                });

            foreach(var v in result)
            {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }

            Console.ReadKey();
        }
    }
}
