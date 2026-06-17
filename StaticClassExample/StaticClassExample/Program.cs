using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee name:" + Employee.GetName());
            Console.WriteLine("Employee Salary:" + Employee.GetSalary());
        }
    }
}
