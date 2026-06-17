using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProject;

namespace ConsoleClassLibraryMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();

           Console.WriteLine( addition.Add(20, 30));
            Console.WriteLine("Sum Is : "+ addition.Add(4,5));
           
        }
    }
}
