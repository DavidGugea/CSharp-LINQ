using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> expr = list
                .Where((item, itemIndex) => itemIndex > 2 && itemIndex < 5).Reverse();

            foreach(int item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
