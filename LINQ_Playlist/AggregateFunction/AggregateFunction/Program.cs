using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 2, 3, 4, 5 };
            int result = Numbers.Aggregate(10, (a, b) => a * b);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
