using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRyCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber = 10;
                int secondNumber = 0;
                int result = firstNumber / secondNumber;
                Console.WriteLine("Hello");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured:{ex.Message}");
                Console.WriteLine($"An error occured:{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("This block will always executed");
            }
        }
    }
}
