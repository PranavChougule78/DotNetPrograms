using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveorNegativeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("num is positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("num is negative");

            }
            else
            {
                Console.WriteLine("Num is Zero");
            }
        }
    }
}
