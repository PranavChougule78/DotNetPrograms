using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram
{
  public class Calculator
  {
        public int Addition(int a,int b)
        {
            return a + b;
        }
        public int Substraction(int a,int b)
        {
            return a - b;
        }
        public int Multiplication(int a,int b)
        {
            return a * b;
        }
        public int Division(int a,int b)
        {
            return (a / b);
        }
  
        
        
       
        static void Main(string[]args)
        {
            Calculator calc = new Calculator();
            int result1 = calc.Addition(300, 200);
            int result2 = calc.Substraction(20, 5);
            int result3 = calc.Multiplication(4, 2);
            int result4 = calc.Division(5, 2);
            
            Console.WriteLine("Addition:" + result1);
            Console.WriteLine("Substraction:"+result2);
            Console.WriteLine("Multiplication:"+result3);
            Console.WriteLine("dividion:" + result4);
       
         
           
        }
    }
}
