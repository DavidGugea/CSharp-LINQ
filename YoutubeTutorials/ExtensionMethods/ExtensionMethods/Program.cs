using System;
using System.Linq;
using ExtensionMethods.Extensions;
using ExtensionMethods.SomeClassLibrary;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            // Console.WriteLine("Brendan".EqualsIns("BRENDAN"));

            var brendan = new Person { Age = 22 };
            Console.WriteLine(brendan.IsOfDrinkingAge());

            Console.ReadKey();
        }
    }
}
