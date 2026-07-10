using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 111;
            int temp = n;
            int rev = 0;
            while(n>0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if (temp==rev)
            {
                Console.WriteLine("No is palindrome");

            }
            else
            {
                Console.WriteLine("No is not palindrome");
            }
        }
    }
}
