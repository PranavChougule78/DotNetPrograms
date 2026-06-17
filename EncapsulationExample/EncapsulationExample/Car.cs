using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Car
    {
        public void Car()
        {
            Console.WriteLine("Unique feature");
        }
        public void Engine()
        {
            Console.WriteLine("Engine");
        }
        public void Engine { get; set; }
    }
}
