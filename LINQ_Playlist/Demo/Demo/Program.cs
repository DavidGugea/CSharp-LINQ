using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "India", "USA", "UK" };
            int? result = null;

            foreach(string str in countries)
            {
                if(!result.HasValue || str.Length > result)
                {
                    result = str.Length;
                }
            }

            Console.WriteLine(string.Format("The biggest cuontry name has {0} characters in its name", result));

            Console.ReadKey();
        }
    }
}
