using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalculation;

namespace StaticCtorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price.GetPrice();
            Console.WriteLine("Old price is"+Price.GetPrice());
            Console.WriteLine("New Price is" + Price.SetPrice(100));

            CalculationExtension priceCalculation = new CalculationExtension();
            Console.WriteLine(Convert.ToString( priceCalculation.CalculatePrice(100, 8)));
            Console.WriteLine(Convert.ToString(priceCalculation.CalculatePrice(105, 10)));
            Console.WriteLine(Convert.ToString(priceCalculation.CalculatePrice(200, 2)));

        }
      
        
    }
}




