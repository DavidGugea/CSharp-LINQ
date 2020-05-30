using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes3
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new { a = "a", b = 2 }; // can't add another property with value null : example for c = null -> error
            var obj2 = new { c = "a", x = 2, y = 3 };
            
            /*
            Compiler creates:

            internal class ??????{
                public string a {get; set;}
                public int b {get; set;}
            }
            */

            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.b);

            Console.ReadKey();
        }
    }
}
