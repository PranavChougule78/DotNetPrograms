
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace PriceManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <Price> products = new List<Price>();

            products.Add(new Price
            {
                ProductName = "Ipad",
                Amount = 10000,
                Status = true
            });

            products.Add(new Price
            {
                ProductName = "Buds",
                Amount = 500,
                Status = true,
            });
            products.Add(new Price
            {
                ProductName = "Thermometer",
                Amount = 1000,
                Status = true,

            });
            products.Add(new Price
            {
                ProductName = "Trimmer",
                Amount = 1500,
                Status = true,
            });
            Console.WriteLine("total Elements: " + products.Count);

            foreach (Price p in products)
            {
               Console.WriteLine($"Product Name :{p.ProductName}, Product Price: {p.Amount},product status: {p.Status}");
            }



        }
    }
}
