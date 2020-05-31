using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "x", lastName = "e", age = 20 },
                new Student{firstName = "x", lastName = "d", age = 25 },
                new Student{firstName = "x", lastName = "c", age = 20 },
                new Student{firstName = "x", lastName = "b", age = 25 }, 
                new Student{firstName = "x", lastName = "a", age = 20 }
            };

            /*
            IEnumerable<string> expr = from student in students
                                       orderby student.firstName, student.lastName
                                       select student.ToString();
            */

            IEnumerable<string> expr = students
                .OrderBy(student => student.firstName)
                .ThenBy(student => student.lastName)
                .Select(student => student.ToString());

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
