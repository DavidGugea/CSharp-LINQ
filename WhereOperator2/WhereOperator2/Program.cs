using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereOperator2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "Student01", secondName = "01", age = 16, ID = 8923479},
                new Student{firstName = "Student02", secondName = "02", age = 20, ID = 2839494},
                new Student{firstName = "Student03", secondName = "03", age = 17, ID = 3284844},
                new Student{firstName = "Student04", secondName = "04", age = 13, ID = 4398249},
                new Student{firstName = "Student05", secondName = "05", age = 12, ID = 8348975}
            };

            IEnumerable<string> expr = students
                .Where((student, studentIndex) => studentIndex >= 2 && studentIndex < 4)
                .Select(student => string.Format("{0} -- > {1}", student.firstName, student.ID));

            foreach(string item in expr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
