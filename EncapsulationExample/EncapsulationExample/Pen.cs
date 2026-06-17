using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Pen
    {
        public void Refill()
        {
            Console.WriteLine("Refill filled");
        }
        public void Ink()
        {
            Console.WriteLine("Ink");
        }
        public string Paper {  get; set; }



    }
}
