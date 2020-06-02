using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOperators
{
    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London"}
            };

            var employeeByJobTitle = listEmployees.ToLookup(x => x.JobTitle);

            Console.WriteLine("Employees grouped by job title.");

            foreach(var kvp in employeeByJobTitle)
            {
                Console.WriteLine(kvp.Key);
                
                foreach(var employee in employeeByJobTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" + employee.JobTitle + "\t" + employee.City);
                }
            }

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }

            var employeeByCity = listEmployees.ToLookup(x => x.City);

            Console.WriteLine("Employees grouped by city");

            foreach(var kvp in employeeByCity)
            {
                Console.WriteLine(kvp.Key);

                foreach(var employee in employeeByCity[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" + employee.JobTitle + "\t" + employee.City);
                }
            }

            Console.ReadKey();
        }
    }
}