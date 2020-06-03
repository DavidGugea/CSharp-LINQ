using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike" },
                new Employee { ID = 101, Name = "Mike" },
                new Employee { ID = 102, Name = "Mary" }
            };
            var result = list.Select(x => new { x.ID, x.Name }).Distinct();

            foreach(var v in result)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }

            Console.ReadKey();
        }
    }
}