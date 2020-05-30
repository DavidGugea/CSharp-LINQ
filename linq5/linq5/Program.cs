using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq5
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Name = "Customer01", Age = 10 },
                new Customer { Name = "Customer02", Age = 15 },
                new Customer { Name = "Customer03", Age = 72 },
                new Customer { Name = "Customer04", Age = 16 },
                new Customer { Name = "Customer05", Age = 24 }
            };

            IEnumerable<string> expr_extensionMethods = customers
                                                            .Where(customer => Int32.Parse(customer.Name[customer.Name.Length - 1].ToString()) < 2)
                                                            .Select(customer => customer.Name);

            IEnumerable<int> expr_sql = from customer in customers
                                        where customer.Age < 20
                                        select customer.Age;

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
