using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            Array.Reverse(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


        }
    }
}
