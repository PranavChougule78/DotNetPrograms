using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Teacher> Teachers = new Dictionary<int, Teacher>();

            Teachers.Add(1, new Teacher { Id = 1, Name = "Saurabh", Salary = 50000 });

            Teachers.Add(2, new Teacher { Id = 2, Name = "Vijay", Salary = 100000 });

            Teachers.Add(3, new Teacher { Id = 3, Name = "Sachin", Salary = 50000 });

            Teachers.Add(4, new Teacher { Id = 4, Name = "Viraj", Salary = 400000 });

            Teachers.Add(5, new Teacher { Id = 5, Name = "Dev", Salary = 150000 });

            Teachers.Add(6, new Teacher { Id = 6, Name = "Om", Salary = 30000 });
            {
                Console.WriteLine("Total Teacher is:"+ Teachers.Count);
            }
            foreach(KeyValuePair<int,Teacher>Teacher in Teachers)
            {
                Console.WriteLine($"Key: {Teacher.Key}, Teacher Id: {Teacher.Value.Id}, Name:{Teacher.Value.Name},Salary{Teacher.Value.Salary}");

            }
            Console.ReadLine();





        }
    }
}
