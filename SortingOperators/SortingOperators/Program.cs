using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> nums = x
                .Where((num, numIndex) => numIndex > 2 && numIndex < 7)
                .OrderBy(num => num);

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
