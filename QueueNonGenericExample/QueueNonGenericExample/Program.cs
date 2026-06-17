using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNonGenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue cars = new Queue();
            cars.Enqueue("Volvo");
            cars.Enqueue("BMW");
            cars.Enqueue("Ford");
            cars.Enqueue("Mazda");

            Console.WriteLine("Size of collection is " + cars.Count);

            Console.WriteLine("First car:" + cars.Peek());

            Console.WriteLine("First car:" +  cars.Dequeue());

            Console.WriteLine("size of collection is " + cars.Count);


        }
    }
}
