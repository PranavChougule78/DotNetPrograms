using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePrinter printer = new Printer();
            printer.ColorPrint();
        }
    }
}
