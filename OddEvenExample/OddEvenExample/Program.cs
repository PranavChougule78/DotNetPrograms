using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenExample
{
        class Program
        {
            static void Main(string[] args)
            {
                int number;

                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }

                Console.ReadLine();
            }
        }
    
}

