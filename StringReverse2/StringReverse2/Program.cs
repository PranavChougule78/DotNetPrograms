using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Reversed String: " + rev);
        }
    }
}
