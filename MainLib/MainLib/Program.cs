using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass1;

namespace MainLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();

            Console.Write("Enter first no : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second no : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = addition.Add(num1, num2);

            Console.WriteLine("Sum is : " + result);

            Console.ReadLine();

        }
    }
}
