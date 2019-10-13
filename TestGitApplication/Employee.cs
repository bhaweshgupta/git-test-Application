using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApplication
{

    class Employee
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public int Experience { set; get; }

        public static void PromoteEmployee(List<Employee> employeelist)
        {
            foreach (Employee employee in employeelist)
            {
                if (employee.Experience > 5)
                {
                    Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
                }
            }
        }
    }
}
