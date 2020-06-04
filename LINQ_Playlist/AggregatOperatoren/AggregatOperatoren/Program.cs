using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());

            Console.ReadKey();
        }
    }
}
