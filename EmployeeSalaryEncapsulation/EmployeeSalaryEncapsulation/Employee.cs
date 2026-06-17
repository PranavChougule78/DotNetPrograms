using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryEncapsulation
{
 
    
        class Program
        {
            static void Main()
            {
                Employee emp = new Employee();
                emp.Salary = 25000;

                Console.WriteLine("Salary: " + emp.Salary);

            }
        }
    
}
