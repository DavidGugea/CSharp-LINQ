using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    class Program
    {
        public static string[] monate =
        {
            "Januar", "Februar", "Marz", "April", "Mai", "Juni",
            "Juli", "August", "September", "Oktober", "November", "Dezember"
        };

        static void Main(string[] args)
        {
            var expr = from s in monate
                       where s.Length == 6
                       orderby s
                       select s.ToUpper();

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
