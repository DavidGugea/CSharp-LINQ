using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2.add(8));
            Console.WriteLine(12.minus(2));
            Console.WriteLine(2.multiply(5));
            Console.WriteLine(50.divide(5));

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            int x = 2;
            x.test();

            Console.ReadKey();
        }
    }
}
