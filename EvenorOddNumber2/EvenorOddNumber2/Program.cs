using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenorOddNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2== 0)
            {
                Console.WriteLine("no is even");
            }
            else
            {
                Console.WriteLine("no is odd");
            }
        }
    }
}
