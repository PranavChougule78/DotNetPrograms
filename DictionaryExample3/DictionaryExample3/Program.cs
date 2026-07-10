using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> Students = new Dictionary<int, Student>();

            Students.Add(1, new Student { Id = 1, Name = "Pranav", Age = 19 });

            Students.Add(2, new Student { Id = 2, Name = "Aditya", Age = 20 });

            Students.Add(3, new Student { Id = 3, Name = "Viraj", Age = 20 });

            Console.WriteLine("Total Students is: " + Students);

            foreach (KeyValuePair<int, Student> Student in Students)
            {
                Console.WriteLine($"Key: {Student.Key},Student Id is: {Student.Value.Id}, Name : {Student.Value.Name}, Age: {Student.Value.Age}");
            }



        }
    }
}
