using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a + " is Largest");
            else
                Console.WriteLine(b + " is Largest");
        }
    }
}
