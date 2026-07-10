using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> cars = new Queue<string>();

            cars.Enqueue("BMW");
            cars.Enqueue("Mercedes - D450");
            cars.Enqueue("Audi - A5");
            Console.WriteLine("Total count:" + cars.Count);
            cars.Dequeue();
            Console.WriteLine("Total count:" + cars.Count);
            Console.WriteLine("Current Model:" +cars.Peek());
        }
    }
}
