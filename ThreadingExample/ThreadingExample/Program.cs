using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNumber);
            Thread thread1 = new Thread(PrintValues);
            thread.Start();
            thread1.Start();
            //PrintNumber();
        }
        public static void PrintNumber()
        {
            Console.WriteLine("Starting PrintNumber Method" + DateTime.Now);
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Number:"+i);
            }
            Console.WriteLine("Ending PrintNumber Method" + DateTime.Now);
        }

        public static void PrintValues()
        {
            Console.WriteLine("Starting PrintNumber Method" + DateTime.Now);
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Number");
            }
            Console.WriteLine("Ending PrintNumber Method" + DateTime.Now);
        }
    }
}