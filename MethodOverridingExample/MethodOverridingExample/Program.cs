using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MethodOverridingExample.Printer;

namespace MethodOverridingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.print();

            Printer cp = new ColourPrinter();
            cp.print();

            BlackAndwhitePrinter blackAndwhitePrinter = new BlackAndwhitePrinter();
            blackAndwhitePrinter.print();
        }
    }
}
