using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderServices
    {
        public List<Order> GetOrder()
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 01, Qty = 02, TotalPrice = 100 },
             new Order { OrderId = 02, Qty = 02, TotalPrice = 1200 },
              new Order { OrderId = 03, Qty = 03, TotalPrice = 1500 },
            };
            return orders;

        }
    }
}

