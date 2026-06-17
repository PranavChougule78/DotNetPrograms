using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Yor are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligiblle for voting");
            }
        }
    }
}
