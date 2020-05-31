using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "x", lastName = "e", age = 20, subjects = new List<string> {
                    "Math", "German", "English"
                } },
                new Student{firstName = "x", lastName = "d", age = 25, subjects = new List<string>
                {
                    "German", "English"
                } },
                new Student{firstName = "x", lastName = "c", age = 17, subjects = new List<string>
                {
                    "Math"
                } },
                new Student{firstName = "x", lastName = "b", age = 20, subjects = new List<string>
                {
                    "German"
                } },
                new Student{firstName = "x", lastName = "a", age = 25, subjects = new List<string>
                {
                    "English"
                } }
            };

            string[] subjectsToGroupBy = new string[] { "Math", "German", "English" };

            foreach(string subjectToGroupBy in subjectsToGroupBy)
            {
                IEnumerable<IGrouping<bool, Student>> expr = students
                    .GroupBy(x => x.subjects.Contains(subjectToGroupBy));

                foreach(IGrouping<bool, Student> group in expr)
                {
                    if (!group.Key)
                    {
                        continue;
                    }

                    Console.WriteLine(string.Format("Subject : {0} ( Count : {1} )", subjectToGroupBy, group.Count()));
                    Console.WriteLine("---------------------------------------------------------------------------------------------");

                    IEnumerable<string> studentOrdered = group
                        .OrderBy(student => student.firstName)
                        .ThenBy(student => student.lastName)
                        .ThenBy(student => student.age)
                        .Select(student => string.Format("{0} {1} ( {2} years old )", student.firstName, student.lastName, student.age));

                    foreach(string student in studentOrdered)
                    {
                        Console.WriteLine(student);
                    }
                }

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
