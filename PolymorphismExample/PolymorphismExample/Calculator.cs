using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is:{a + b}");
        }
        public void Add(int a,int b, int c)
        {
            Console.WriteLine($"sum of {a} and {b} and {c} is:{a + b + c}");
        }
        public void Add(double a,double b)
        {
            Console.WriteLine($" sum of {a} and {b} is:{a+b}");
        }
    }
}
