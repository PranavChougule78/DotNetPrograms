using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderServices service = new OrderServices();
            var orders = service.GetOrder();
            Console.WriteLine("Total count " + orders.Count);
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order Id : {order.OrderId}, Qty : {order.Qty}, Total Price : {order.TotalPrice}");
            }



        }
    }
}
