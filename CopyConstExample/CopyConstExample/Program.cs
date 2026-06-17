using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address tempAddress = new Address("Baner" , "Pune" , "Hyderabad" , "Goa" , "Bangalore");
            Address perAddress = new Address(tempAddress);

            perAddress.PrintAddress();
        }
    }
}
