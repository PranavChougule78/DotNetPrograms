using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeywordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int basePrice = 10;

            Console.WriteLine("Welcome to the store");
            Console.WriteLine($"The base price of the item is: {basePrice} dollars ");

            Price price = new Price(20);
            price.DisplayPrice();


        }
    }
}
