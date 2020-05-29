using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] filteredNumbers = numbers.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine(filteredNumbers);
            
            */

            Person[] people = new[] {
                new Person{Name = "Brendan Enrick", Age = 18 },
                new Person{Name = "Michael Enrick", Age = 28 },
                new Person{Name = "Steve Smith", Age = 38 },
                new Person{Name = "John Smith", Age = 34 },
                new Person{Name = "Brendan Smith", Age = 16 },
            };
            
            string[] linqedPeople = people
                .GroupBy(x => x.Age / 10)
                .Select(x => string.Format("People in their {1}s ({0})", string.Join(", ", x.Select(p => p.Name).ToArray()), x.Key * 10))
                .ToArray();
            
            Console.WriteLine(string.Join(",", linqedPeople));
            Console.WriteLine(linqedPeople.FirstOrDefault());
            Console.ReadKey();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
