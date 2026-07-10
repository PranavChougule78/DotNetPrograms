using System;
using System.Collections.Generic;

namespace DictionaryExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, College> colleges = new Dictionary<int, College>();

            colleges.Add(1, new College { Id = 1, Name = "Sangola College", Fee = 20000 });

            colleges.Add(2, new College { Id = 2, Name = "Fergusson College", Fee = 80000 });

            colleges.Add(3, new College { Id = 3, Name = "COEP College", Fee = 90000 });

            Console.WriteLine("Total number of Colleges is : " + colleges.Count);

            foreach (KeyValuePair<int, College> college in colleges)
            {
                Console.WriteLine($"Key: {college.Key}, College Id: {college.Value.Id}, Name: {college.Value.Name}, Fee: {college.Value.Fee}");
            }

            Console.ReadLine();
        }
    }

   
}