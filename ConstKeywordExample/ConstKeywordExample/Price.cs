using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeywordExample
{
    internal class Price
    {

        private readonly int basePrice;

        public Price(int Price)
        {
            basePrice = Price;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"The base price of the item is:{basePrice} dollars ");
        }
    }
}
