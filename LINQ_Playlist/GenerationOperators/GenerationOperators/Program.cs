using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetData() ?? Enumerable.Empty<int>();
            Console.WriteLine(result.Count());
            
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
            

            Console.ReadKey();
        }

        public static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}