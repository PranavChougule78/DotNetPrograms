using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largestofthreenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number:");
            c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine(a + "is largest");
            }
            else if(b>c)
            {
                Console.WriteLine(b+"is largest");
            }
            else
            {
                Console.WriteLine(c + "is Largest");
            }
        }
    }
}
