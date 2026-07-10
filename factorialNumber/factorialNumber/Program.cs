using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        
            
            {
                int n = 5;
                int fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("Factorial = " + fact);
            }
        }
    }
    
}
