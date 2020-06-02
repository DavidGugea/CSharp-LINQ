using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPagin_Using_SkipAndTake
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Student.GetAllStudents();

            do
            {
                Console.WriteLine("Please enter Page Numbers - 1, 2, 3 or 4");
                int pageNumber = 0;

                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber >= 1 && pageNumber <= 4)
                    {
                        int pageSize = 3;
                        IEnumerable<Student> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

                        Console.WriteLine();
                        Console.WriteLine(string.Format("Displaying Page {0}", pageNumber));

                        foreach (Student s in result)
                        {
                            Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Page number must be an integer between 1 and 4.");
                    }
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and 4.");
                }
            } while (true);
        }
    }
}
