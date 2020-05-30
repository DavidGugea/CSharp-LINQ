using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq6
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{ Name = "Customer01", Age = 15, ID = 23749 },
                new Customer{ Name = "Customer02", Age = 21, ID = 34855 },
                new Customer{ Name = "Customer03", Age = 10, ID = 68754 },
                new Customer{ Name = "Customer04", Age = 6,  ID = 81923 },
                new Customer{ Name = "Customer05", Age = 16, ID = 92342 }
            };

            var expr = customers
                                .Where(customer => Int32.Parse(customer.Name[customer.Name.Length - 1].ToString()) < 5)
                                .OrderBy(customer => customer.Age)
                                .Select(customer => new { customer.Name, customer.Age });
            
            foreach(var item in expr)
            {
                Console.WriteLine(string.Format("Name : {0} | Age : {1}", item.Name, item.Age));

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
