using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monate =
            {
                "Januar", "Februar", "Marz", "April", "Mai", "Juni",
                "Juli", "August", "September", "Oktober", "November", "Dezember"
            };

            IEnumerable<string> items = monate
                                            .Where(s => s.StartsWith("J"))
                                            .OrderBy(s => s)
                                            .Select(s => s.ToLower());

            IEnumerable<string> items_2 = from s in monate
                                          where s.StartsWith("J")
                                          orderby s
                                          select s.ToLower();

            foreach(string item in items)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            foreach(string item in items_2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
