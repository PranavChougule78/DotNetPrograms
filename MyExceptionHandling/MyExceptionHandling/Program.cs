using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }

        }
    }
    
}
