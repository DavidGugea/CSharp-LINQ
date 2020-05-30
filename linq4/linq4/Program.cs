using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{name = "Customer01", age = 16 },
                new Customer{name = "Customer02", age = 20 }, 
                new Customer{name = "Customer03", age = 40 },
                new Customer{name = "Customer04", age = 75 },
                new Customer{name = "Customer05", age = 80 }
            };

            IEnumerable<string> expr_extensionMethods = customers.Select(s => s.name);
            IEnumerable<int> expr_sql = from customer in customers
                                        select customer.age;

            foreach(string customerName in expr_extensionMethods)
            {
                Console.WriteLine(customerName);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            foreach(int customerAge in expr_sql)
            {
                Console.WriteLine(customerAge);
            }

            Console.ReadKey();
        }
    }
}
