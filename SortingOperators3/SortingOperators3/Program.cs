using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "Student01", secondName = "01", land = "Germany", age = 12, ID = 345345345543},
                new Student{firstName = "Student02", secondName = "02", land = "France", age = 13, ID = 345380948095},
                new Student{firstName = "Student03", secondName = "03", land = "Germany", age = 18, ID = 897534598334},
                new Student{firstName = "Student04", secondName = "04", land = "Bulgaria", age = 21, ID = 2839483848934 },
                new Student{firstName = "Student05", secondName = "05", land = "Germany", age = 15, ID = 34534095093455}
            };

            IEnumerable<string> expr = students
                .Where((student, studentIndex) => studentIndex > 2 && studentIndex < 5)
                .OrderBy(student => student.age)
                .ThenBy(student => student.land)
                .Select(student => string.Format("{0} -- > {1} ( {2} )", student.firstName, student.age, student.ID));

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
