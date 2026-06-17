using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] currencies = { "inr", "dollar", "euro", };

            foreach(string c in currencies)
            {
                Console.WriteLine(c);
            }
            
           
        }
    }
}
