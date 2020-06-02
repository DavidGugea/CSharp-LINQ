using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * MY CODE: 
            IEnumerable<int> EmployeeIDS = Employee.GetAllEmployees()
                .Select(employee => employee.EmployeeID);

            foreach(int ID in EmployeeIDS)
            {
                Console.WriteLine(ID);
            }

            -> TUTORIAL: 
            IEnumerable<int> result = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);

            foreach(int id in result)
            {
                Console.WriteLine(id);
            }
            */

            /*
             * MY CODE: 
             IEnumerable<string> firstName_and_gender = Employee.GetAllEmployees()
                .Select(employee => string.Format("{0} - {1}", employee.FirstName, employee.Gender));

             foreach(string item in firstName_and_gender)
             {
                 Console.WriteLine(item);
             }

            -> TUTORIAL: 
            var result = Employee.GetAllEmployees()
                .Select(emp => new
                {
                    FirstName = emp.FirstName,
                    Gender = emp.Gender
                });
            
            foreach(var v in result)
            {
                Console.WriteLine(v.FirstName + " - " + v.Gender);
            }
            */

            /*
             * MY CODE: 
            
            var result = Employee.GetAllEmployees()
                .Select(emp => new
                {
                    FullName = string.Format("{0} {1}", emp.FirstName, emp.LastName),
                    MonthlySalary = emp.AnnualSalary / 12
                });

            foreach(var item in result)
            {
                Console.WriteLine(string.Format("{0} - {1}",
                    item.FullName,
                    item.MonthlySalary
                ));
            }
            
            -> TUTORIAL: 
            var result = Employee.GetAllEmployees().Select(emp => new
            {
                FullName = emp.FirstName + " " + emp.LastName,
                MonthlySalary = emp.AnnualSalary / 12
            });

            foreach(var v in result)
            {
                Console.WriteLine(v.FullName + " - " + v.MonthlySalary);
            }
            */

            /*
             * MY CODE: 
            var result = Employee.GetAllEmployees()
                .Where(emp => emp.AnnualSalary > 50000)
                .Select(emp => new
                {
                    FullName = string.Format("{0} {1}", emp.FirstName, emp.LastName),
                    emp.AnnualSalary,
                    SalaryBonus = (double)emp.AnnualSalary * 0.1
                });

            foreach(var item in result)
            {
                Console.WriteLine(string.Format("{0} : {1} - {2}",
                    item.FullName,
                    item.AnnualSalary,
                    item.SalaryBonus
                ));
            }

            */
            var result = Employee.GetAllEmployees()
                .Where(x => x.AnnualSalary > 50000)
                .Select(emp => new
                {
                    Name = emp.FirstName,
                    AnnualSalary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * .1
                });

            foreach(var v in result)
            {
                Console.WriteLine(v.Name + " : " + v.AnnualSalary + " - " + v.Bonus);
            }

            Console.ReadKey();
        }
    }
}