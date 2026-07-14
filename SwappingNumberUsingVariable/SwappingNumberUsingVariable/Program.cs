using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumberUsingVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.Write("Enter first Number:");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter second Number:");
            b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number= " + a);
            Console.WriteLine("second Number= " + b);



        }
    }

}