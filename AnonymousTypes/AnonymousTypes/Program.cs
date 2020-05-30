using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Vorname = "Jurgen", Nachname = "Kotz", Alter = 51 };

            /*
            
            Anonymous class. Compiler creates : 

            internal class ??????{
                public string Vorname{get; set;}
                public string Nachname {get; set;}
                public int Alter {get; set;}
            }

            */

            Console.WriteLine(person.Vorname);
            Console.WriteLine(person.Nachname);
            Console.WriteLine(person.Alter);

            Console.ReadKey();
        }
    }
}
