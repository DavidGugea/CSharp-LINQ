using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2.Multiply(5));
            Console.WriteLine(-3.Abs());
            Console.WriteLine(3.Abs());

            Console.ReadKey();
        }
    }
}
