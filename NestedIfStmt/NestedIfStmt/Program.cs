using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfStmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            bool hasLicense = true;
            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can Drive");
                }
            }
        }
    }
}