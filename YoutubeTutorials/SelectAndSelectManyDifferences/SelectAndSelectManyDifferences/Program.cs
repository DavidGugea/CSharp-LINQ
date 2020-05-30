using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectAndSelectManyDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> result = Student.GetAllStudents().SelectMany(x => x.Subjects);
            foreach(string str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
