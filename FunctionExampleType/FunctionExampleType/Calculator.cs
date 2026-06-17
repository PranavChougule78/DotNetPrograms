using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExampleType
{
    internal class Calculator
    {
        public int Addition(int x, int y)
        {
          return x + y;

        }
        public int Substraction(int a, int b)
        {
            return a - b;

        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

    }
}
