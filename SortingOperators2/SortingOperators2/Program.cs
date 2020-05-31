using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "Student01", secondName = "01", age = 81, ID = 89324753},
                new Student{firstName = "Student02", secondName = "02", age = 15, ID = 93489589},
                new Student{firstName = "Student03", secondName = "03", age = 26, ID = 32402344},
                new Student{firstName = "Student04", secondName = "04", age = 36, ID = 43534853},
                new Student{firstName = "Student05", secondName = "05", age = 48, ID = 23843249}
            };

            IEnumerable<string> expr = students
                .Where((student, studentIndex) => studentIndex > 1 && studentIndex < 4)
                .OrderByDescending(student => student.age)
                .Select(student => string.Format("{0} -- > {1}", student.firstName, student.ID));

            IEnumerable<string> expr_2 = from student in students
                                         where students.IndexOf(student) > 1 && students.IndexOf(student) < 4
                                         orderby student.age descending
                                         select string.Format("{0} -- > {1}", student.firstName, student.ID);

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            foreach(string item in expr_2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
