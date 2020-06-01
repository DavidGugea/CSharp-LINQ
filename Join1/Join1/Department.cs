using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join1
{
    public class Department
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { Name = "HR", ID = 1 },
                new Department { Name = "IT", ID = 2 },
                new Department { Name = "Payroll", ID = 3 }
            };
        }
    }
}
