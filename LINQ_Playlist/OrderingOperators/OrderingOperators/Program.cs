using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Student names before sorting");
            List<Student> students = Student.GetAllStudents();

            foreach(Student s in students)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();

            IOrderedEnumerable<Student> result = from student in Student.GetAllStudents()
                                                 orderby student.Name descending
                                                 select student;

            Console.WriteLine("Student names after sorting");

            foreach (Student s1 in result)
            {
                Console.WriteLine(s1.Name);
            }

            IOrderedEnumerable<Student> result = from s in Student.GetAllStudents()
                                                 orderby s.TotalMarks, s.Name, s.StudentID descending
                                                 select s;

            foreach(Student s in result)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);
            }
            */
            IEnumerable<Student> students = Student.GetAllStudents();
            Console.WriteLine("Before calling reverse method.");

            foreach (Student s in students)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }

            Console.WriteLine();

            IEnumerable<Student> result = students.Reverse();
            Console.WriteLine("After calling reverse method.");

            foreach(Student s in result)
            {
                Console.WriteLine(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks);
            }
            

            Console.ReadKey();
        }
    }
}
