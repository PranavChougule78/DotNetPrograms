using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , Employee> employees = new Dictionary<int , Employee>();

            employees.Add(1, new Employee { Id = 1 ,Name ="Pranav",Salary = 50000});

            employees.Add(2, new Employee { Id = 2, Name = "Aditya", Salary = 50000 });

            employees.Add(3, new Employee { Id = 3, Name = "Viraj", Salary = 50000 });

            employees.Add(4, new Employee { Id = 4, Name = "Rahul", Salary = 20000 });

            employees.Add(5, new Employee { Id = 5, Name = "Sai", Salary = 25000 });

            employees.Add(6, new Employee { Id = 6, Name = "Sudarshan", Salary = 40000 });

            employees.Add(7, new Employee { Id = 7, Name = "Sarthak", Salary = 60000 });

            employees.Add(8, new Employee { Id = 8, Name = "Parth", Salary = 55000 });

            Console.WriteLine("Total Elements is: " + employees.Count);

            foreach(KeyValuePair<int , Employee> emp in employees)
            {
                Console.WriteLine($"Key: {emp.Key},Employee Id is: {emp.Value.Id}, {emp.Value.Name}, {emp.Value.Salary}");
            }


        }
    }
}
