using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectmanyOperatorInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            @@@@@@@@@@@@@ EXTENSION METHODS @@@@@@@@@@@@@
            
            IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            @@@@@@@@@@@@@ EXTENSION METHODS @@@@@@@@@@@@@
            */

            /*
            // MY CODE :::::::::::::::::::::::::::::
            IEnumerable<string> subjects = from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;
            
            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            /*
            // TUTORIAL CODE :::::::::
            IEnumerable<string> subjects = from student in Student.GetAllStudents()
                                           from subject in student.Subjects
                                           select subject;

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }
            */

            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            /*
            // MY CODE :::::::::::::::::::::::::::::
            IEnumerable<char> letters = stringArray
                                        .Where(str => Array.IndexOf(stringArray, str) == 0)
                                        .SelectMany(str => str);
            
            foreach(char letter in letters)
            {
                Console.WriteLine(letter);
            }
            */

            /*
            IEnumerable<char> result = stringArray.SelectMany(s => s);

            foreach(char c in result)
            {
                Console.WriteLine(c);
            }
            */

            /*
            // MY CODE ( SQL LITE SYNTAX ) ::::::::::::::::::::::::::::
            IEnumerable<char> letters = from str in stringArray
                                        from letter in str
                                        select letter;

            foreach(char letter in letters)
            {
                Console.WriteLine(letter);
            }
            */

            // TUTORIAL CODE ::::::::::::::::::::::::::::::::::::::::::::::::
            IEnumerable<char> result = from s in stringArray
                                       from c in s
                                       select c;

            foreach(char c in result)
            {
                Console.WriteLine(c);
            }

            // I didn't go further because I also didn't go further in my book

            Console.ReadKey();
        }
    }
}
