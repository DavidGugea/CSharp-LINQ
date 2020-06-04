using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesExercise
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person first, Person second)
        {
            return first.Vorname == second.Vorname && first.Nachname == second.Nachname;
        }

        public int GetHashCode(Person person)
        {
            return person.Nachname.GetHashCode() + person.Vorname.GetHashCode();
        }
    }
}
