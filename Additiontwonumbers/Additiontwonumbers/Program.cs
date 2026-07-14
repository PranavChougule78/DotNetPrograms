using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additiontwonumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("Sum ="+ sum);
        }
    }
}
