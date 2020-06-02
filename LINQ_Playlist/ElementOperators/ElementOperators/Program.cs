using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            IEnumerable<int> result = numbers.DefaultIfEmpty(10);
            
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}