using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Pranav", "Rahul", "Amit" };

            foreach (string i in   name)
            {
                Console.WriteLine(i);
            }
        }
    }
}
