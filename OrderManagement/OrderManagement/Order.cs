using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Qty {  get; set; }
        public decimal TotalPrice {  get; set; }
    }
}
