using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "Uk" };

            var result = countries1.SequenceEqual(countries2, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    } 
}