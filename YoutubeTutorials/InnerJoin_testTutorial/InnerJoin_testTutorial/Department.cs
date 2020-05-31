using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin_testTutorial
{
    public class Department
    {
        public string name { get; set; }
        public int ID { get; set; }
        
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { name = "IT", ID = 1 },
                new Department { name = "HR", ID = 2 },
                new Department { name = "Payroll", ID = 3}
            };
        }
    }
}