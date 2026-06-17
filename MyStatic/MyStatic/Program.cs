using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace StaticClassExample
{
    
    public static class Calculator
    {
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = Calculator.Add(90, 20);
            int product = Calculator.Multiply(9, 4);
            int divide = Calculator.Divide(9, 4);
            int substract = Calculator.Substract(10, 4);

            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Multiplication: " + product);
            Console.WriteLine("Divide:" + divide);
            Console.WriteLine("substract:" + substract);
            Console.WriteLine("Addition:" + sum);

            Console.ReadLine();
        }
    }
}