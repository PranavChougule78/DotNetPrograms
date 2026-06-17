using ProtectedExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExample
{
    public sealed class BasePrice
    {
        public BasePrice()
        {
            Console.WriteLine("Base Price Constructor called");
        }
        protected int price;

        protected void DisplayPrice()
        {
            Console.WriteLine($"the price is : {price}");
        }
        protected void Show()
        {
            Console.WriteLine($"the price is:{price}");
        }
        
    }
}

//public class Price : BasePrice
//{
//    public Price(int initialPrice)
//    {
//        price = initialPrice;
//    }
//    public void ShowPrice()
//    {
//        DisplayPrice();
//    }
//}

