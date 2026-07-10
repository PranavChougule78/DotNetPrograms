using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, rev = 0;
            while (n > 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n /= 10;
            }
            Console.WriteLine(temp == rev ? "Palindrome":"Not Plaindrome");
                

                    
        }
    }
}
