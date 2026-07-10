using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Pranav");
            dict.Add(2, "Sachin");
            dict.Add(3, "krish");

            Console.WriteLine("Total count of items in the dictionary:" + dict.Count);

            if (dict.Count > 0)
            {
                foreach (var item in dict.OrderBy(x => x.Value))
                //foreach(KeyValuePair<int,string> item in dict)
                {
                    Console.WriteLine("Key:" + item.Key + ", Value: " + item.Value);
                }
            }
        }
    }
}
