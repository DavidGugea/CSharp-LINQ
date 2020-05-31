using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy_und_ThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person(20, "Benjamin", "Kohl"));
            personList.Add(new Person(19, "Benjamin", "Blume"));
            personList.Add(new Person(22, "Alina", "Müller"));
            personList.Add(new Person(43, "Daniela", "Kohl"));
            personList.Add(new Person(27, "Carlos", "Sanchez"));

            /*
            var personQuery = from person in personList
                              orderby person.FirstName, person.LastName
                              select person;
            */

            var personQuery = personList
                .OrderByDescending(person => person.FirstName)
                .ThenBy(person => person.LastName);

            foreach(Person person in personQuery)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ( {2} )", FirstName, LastName, Age);
        }
    }
}
