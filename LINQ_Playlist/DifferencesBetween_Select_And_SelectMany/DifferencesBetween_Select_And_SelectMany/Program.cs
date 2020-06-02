using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferencesBetween_Select_And_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * MY CODE SELECT : 
            IEnumerable<List<string>> subjects = Student.GetAllStudents()
                .Select(student => student.Subjects);

            foreach(List<string> subjectList in subjects)
            {
                foreach(string subject in subjectList)
                {
                    Console.WriteLine(subject);
                }
            }

            MY CODE SELECT SQL SYNTAX:

            IEnumerable<List<string>> subjects = from subjectList in Student.GetAllStudents()
                                                 select subjectList.Subjects;

            foreach(List<string> subjectsList in subjects)
            {
                foreach(string subject in subjectsList)
                {
                    Console.WriteLine(subject);
                }
            }

            MY CODE SELECTMANY:
            IEnumerable<string> subjects = Student.GetAllStudents()
                .SelectMany(student => student.Subjects);

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            MY CODE SELECTMANY SQL SYNTAX:
            IEnumerable<string> subjects = from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            IEnumerable<string> result = Student.GetAllStudents().SelectMany(x => x.Subjects);
            
            foreach(string str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
