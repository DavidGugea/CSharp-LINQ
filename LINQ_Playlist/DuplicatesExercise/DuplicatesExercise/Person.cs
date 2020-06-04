using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesExercise
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Person(string nn, string vn)
        {
            Vorname = vn;
            Nachname = nn;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Vorname, Nachname);
        }
    }
}
