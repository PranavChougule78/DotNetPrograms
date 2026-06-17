using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "pranav", Age = 22 },
                new Employee { Name = "sachin", Age = 25 },
                new Employee { Name = "krushnan", Age = 24 },
            };


            foreach(Employee e in employees)
            {
                Console.WriteLine($"Employee Name: {e.Name}, Employee Age:{e.Age}");
            }










            // List<string> cars = new List<string>();
            // cars.Add("Volvo");
            // cars.Add("BMW");
            // cars.Add("Ford");
            // cars.Add("Mazda");


            // Console.WriteLine("Total size of the list:"+ cars.Count);
            // cars.Remove("Volvo");
            // cars.RemoveAt(1);
            //Console.WriteLine("Total size of the list:" + cars.Count);

            // if (cars.Count > 0)
            // {
            //     foreach (string car in cars)
            //     {
            //         Console.WriteLine(car);
            //     }
            // }

        }
    }
}
