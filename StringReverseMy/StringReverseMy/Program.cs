using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseMy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Input");
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            Array.Reverse(ch);

            Console.WriteLine(new string(ch));
        }
    }
}
