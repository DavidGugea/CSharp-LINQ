using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries =
            {
                "Australia",
                "Canada",
                "Germany",
                "US",
                "India",
                "UK",
                "Italy"
            };

            IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);

            foreach(string str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
