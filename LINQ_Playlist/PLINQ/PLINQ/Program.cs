using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            IEnumerable<int> result = numbers.AsParallel()
                .Where(num => num % 2 == 0)
                .OrderByDescending(x => x)
                .Select(x => x);

            foreach(int number in result)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
