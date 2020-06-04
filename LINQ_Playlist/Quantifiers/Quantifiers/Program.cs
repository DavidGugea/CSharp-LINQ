using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "USA", "INDIA", "UK" };
            var result = countries.Contains("india", StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}