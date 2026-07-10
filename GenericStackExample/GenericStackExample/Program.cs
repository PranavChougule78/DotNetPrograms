using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int > numbers = new Stack<int>();   
            
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);    
            numbers.Push(6);
            numbers.Push(7);
            numbers.Push(8);
            numbers.Push(9);
            numbers.Push(10);

            Console.WriteLine("Total Count" + numbers.Count);

            numbers.Pop();
            Console.WriteLine("Total Count"+ numbers.Count);
            Console.WriteLine("Total Count"+ numbers.Peek());
                
             
        }
    }
}
