using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter first Number:");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter second Number:");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

           

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number= " + a);
            Console.WriteLine("second Number= " + b);
        }
    }
}
