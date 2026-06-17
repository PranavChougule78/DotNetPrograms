using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 20;

            Console.WriteLine("Addition :"+ Calculator.add(50,20));

            Console.WriteLine("Substract :" + Calculator.subtract(50, 20));

            Console.WriteLine("Multiply :" + Calculator.multiply(50, 20));


            Console.WriteLine("Divide :" + Calculator.divide(50, 20));





        }
    }
}
