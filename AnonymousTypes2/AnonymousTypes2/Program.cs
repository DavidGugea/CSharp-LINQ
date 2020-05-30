using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { firstName = "Gugea", secondName = "David-Ioannis", age = 16 };

            /* 
            Compiler creates : 

            internal class ??????{
                public string firstName{get; set;}
                public string secondName{get; set;}
                public int age{get; set;}
            }
            */

            Console.WriteLine(person.firstName);
            Console.WriteLine(person.secondName);
            Console.WriteLine(person.age);

            Console.ReadKey();
        }
    }
}
