using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionIntersectExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 3, 6, 7, 8 };

            var result = numbers1.Except(numbers2);

            foreach(var v in result)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }
}