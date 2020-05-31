using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin_testTutorial
{
    public class Employee
    {
        public string firstName { get; set; }
        public int age { get; set; }
        public int ID { get; set; }
        
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>(){
                new Employee { firstName = "employee01", age = 20, ID = 1 },
                new Employee { firstName = "employee02", age = 25, ID = 2 },
                new Employee { firstName = "employee03", age = 30, ID = 1 },
                new Employee { firstName = "employee04", age = 35, ID = 2 }
            };
        }
    }
}