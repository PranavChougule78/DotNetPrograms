using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "12";
            Console.WriteLine(value);   

          

            int number = Convert.ToInt32(12);
            Console.WriteLine(number);

            int number2 = int.Parse("123");
            double price = 12.78;
            int value1 = (int)price;

            Console.WriteLine(value1);

            string name = null;

            string name2 = name.ToString();
            Console.WriteLine(2);
            Console.WriteLine(name.ToString());


        }
    }
}
