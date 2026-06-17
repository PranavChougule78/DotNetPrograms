using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCtorExample
{
    public class Price
    {
         static Price()
        {
            Console.WriteLine("Static constructor called");
        }
        public static decimal GetPrice()
        {
            return 140.22m;
        }
        public static decimal SetPrice(decimal price)
        {
            return price;
        }
    }
}
