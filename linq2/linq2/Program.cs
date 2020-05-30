using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x =
            {
                "Januar", "Februar", "Marz", "April", "Mai", "Juni",
                "Juli", "August", "September", "Oktober", "November", "Dezember"
            };

            var expr = from s in x
                       where s.StartsWith("J")
                       select s.ToLower();

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
