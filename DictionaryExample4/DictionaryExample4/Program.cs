using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Car> Cars = new Dictionary<int, Car>();

            Cars.Add(1, new Car { Id = 1, Name = "Mercedes", Price = 20000000 });
            Cars.Add(2, new Car { Id = 2, Name = "ScorpioN", Price = 2000000 });
            Cars.Add(3, new Car { Id = 3, Name = "Audi", Price = 200000000 });
            Cars.Add(4, new Car { Id = 4, Name = "Tesla", Price = 300000000 });
            Cars.Add(5, new Car { Id = 5, Name = "Fortuner", Price = 4000000 });

            Console.WriteLine("Total Cars are: " + Cars.Count);

            foreach (KeyValuePair<int, Car> car in Cars)
            {
                Console.WriteLine($"Key: {car.Key}, Car Id: {car.Value.Id}, Name: {car.Value.Name}, Price: {car.Value.Price}");
            }

            Console.ReadLine();
        }
    }
}
