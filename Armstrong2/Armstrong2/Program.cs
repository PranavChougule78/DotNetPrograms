using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 13;
            int temp = n, sum = 0;
            while (n>0)
            {
                int r = n % 10;
                sum += r * r * r;
                n /= 10;

            }
            if(sum==temp)
            {
                Console.WriteLine("no is Armstrong");

            }
            else
            {
                Console.WriteLine("no is not armstrong");
            }
        }
    }
}
