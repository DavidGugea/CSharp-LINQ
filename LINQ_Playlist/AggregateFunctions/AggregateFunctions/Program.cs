using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "India", "USA", "UK" };
            Console.WriteLine(string.Format("The largest country name has {0} characters in its name", countries.Max(country => country.Length)));

            Console.ReadKey();
        }
    }
}
