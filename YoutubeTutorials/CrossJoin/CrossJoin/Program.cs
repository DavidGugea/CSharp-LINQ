using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Employee.GetAllEmployees().Join(
                    Department.GetAllDepartments(),
                    e => 2,
                    d => 2,
                    (e, d) => new { e, d });

            foreach(var v in result)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }

            Console.ReadKey();
        }
    }
}