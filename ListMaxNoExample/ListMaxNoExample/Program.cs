using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMaxNoExample
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            List<int> List = new List<int>();
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < number;  i++)
            {
                List.Add(i);
            }

            Console.WriteLine("total count is "+ List.Count);




        }
    }
}
