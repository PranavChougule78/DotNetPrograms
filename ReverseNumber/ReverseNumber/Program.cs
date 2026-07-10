using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int rev = 0;

            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num =  num/ 10;
            }

            Console.WriteLine(rev);
        }
    }
}
