using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast_and_OfType_Operators_AndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 1; i < 4; i++)
            {
                list.Add(i);
            }

            list.Add("4");
            list.Add("ABC");

            IEnumerable<int> result = list.OfType<int>();

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
