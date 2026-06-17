using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber = 19, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                string[] busType = { "Mercedes", "Volvo", "Scania" };
                Console.WriteLine(busType[4]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you cannot divide a number by zero. please provide a non-zero diisor.");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The index you are trying to access is out of range. please provide a valid index.");
                Console.WriteLine("Error Details :" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. please check your input and try again");
                Console.WriteLine("An unexpected error occurred" + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block is always executed)");
            }
        }



    }
    
}
