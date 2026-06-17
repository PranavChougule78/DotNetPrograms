using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueDataTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 1;
            short number2 = 2;
            int number3 = 10;
            long number4 = 20;
            Console.WriteLine("Byte:"+number);
            Console.WriteLine("Short:"+number2);
            Console.WriteLine("Int:"+number3);
            Console.WriteLine("Long:"+number4);

            Console.WriteLine("Enter any Number");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number5);

            //Reference Data type
            string name = "Pranav";
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Enter your name");

            String name2 = Console.ReadLine();
            Console.WriteLine("You entered:" + name2);
    
        }
    }
}
