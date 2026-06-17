using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList cars = new SortedList();
            cars.Add("BMW", "X5");
            cars.Add("Audi", "A6");
            cars.Add("Mercedes", "C-Class");

            Console.WriteLine("Total collection size:" + cars.Count);
            foreach(DictionaryEntry car in cars)
            {
                Console.WriteLine("key :" + car.Key + ", Value:"+ car.Value);   
            }

        }
    }
}
