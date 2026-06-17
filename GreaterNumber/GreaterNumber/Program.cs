using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter year");

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is not leap");
            }
        }
    }
}
