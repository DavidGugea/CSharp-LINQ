using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators4
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} [{2}]", firstName, lastName, age);
        }
    }
}
