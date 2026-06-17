using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExampleType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetEmployeeName();
            Console.WriteLine(employee.GetEmployeePan());
            Console.WriteLine(employee.GetEmployeeSalary(123));

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Addition(5, 4));
            Console.WriteLine(calculator.Substraction(5, 4));
            Console.WriteLine(calculator.Multiplication(51.1, 34.1));
            Console.WriteLine(calculator.Divide(5.4m, 6.4m));



        }
    }
}
