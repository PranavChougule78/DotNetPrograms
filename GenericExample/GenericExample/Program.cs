using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("addition of two integers:" + calculator.Add(5, 10));
            Console.WriteLine("addition of two doubles:" + calculator.Add(5.5, 10.5));
            Console.WriteLine("addition of two strings:" + calculator.Add("HII","Hello"));


        }
    }
}
