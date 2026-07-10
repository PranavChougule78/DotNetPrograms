using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n, sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum += r * r * r;
                n /= 10;
            }
            Console.WriteLine(sum == temp?"Armstrong":"NotArmstrong");
        }
    }
}
