using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * MY CODE: 
            IEnumerable<IEnumerable<string>> subjectsLists = Student.GetAllStudents()
                .Select(x => x.Subjects);

            foreach(IEnumerable<string> subjectList in subjectsLists)
            {
                foreach(string subject in subjectList)
                {
                    Console.WriteLine(subject);
                }
            }

            -> TUTORIAL:
            IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            /*
             * MY CODE:
             * 

            IEnumerable<string> subjects = from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            -> TUTORIAL: 
            IEnumerable<string> subjects = from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            /*
             * MY CODE:
             
            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<IEnumerable<char>> chars = stringArray
                .Select(str => str).Select(charFromString => charFromString);

            foreach(IEnumerable<char> charE in chars)
            {
                foreach(char charItem in charE)
                {
                    Console.WriteLine(charItem);
                }
            }

            --------------------------------------------------------------------------------

            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<char> charItems = stringArray.SelectMany(str => str);

            foreach(char item in charItems)
            {
                Console.WriteLine(item);
            }
            */

            /*
            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            // IEnumerable<char> result = stringArray.SelectMany(s => s);
            
             * MY CODE SQL SYNTAX: 
            IEnumerable<char> result = from str in stringArray
                                       from charItem in str
                                       select charItem;
            

            IEnumerable<char> result = from s in stringArray
                                       from c in s
                                       select c;

            foreach(char c in result)
            {
                Console.WriteLine(c);
            }
            */

            /*
             * TUTORIAL:

            IEnumerable<string> subjects = (from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject).Distinct();

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            /* 
             * MY STUDENT:
            var studentWithSubjects = Student.GetAllStudents().Select(student => new
            {
                student.Name,
                student.Subjects
            });
            
            foreach(var item in studentWithSubjects)
            {
                foreach(string subject in item.Subjects)
                {
                    Console.WriteLine(string.Format("{0} - {1}", item.Name, subject));
                }
            }

            -> TUTORIAl: 
            var result = Student.GetAllStudents().SelectMany(s => s.Subjects, (student, subject) => new
            {
                StudentName = student.Name,
                SubjectName = subject
            });
            */

            var result = from student in Student.GetAllStudents()
                         from subject in student.Subjects
                         select new
                         {
                             StudentName = student.Name,
                             SubjectName = subject
                         };

            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " - " + v.SubjectName);
            }

            Console.ReadKey();
        }
    }
}
