using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IBasePrinter
    {
        void Print();

        void ColorPrint();
    }
     
    public class Printer : IBasePrinter
    {
        public void Print()
        {
            Console.WriteLine("printing document");
        }
        public void ColorPrint()
        {
            Console.WriteLine("Print color documennt");
        }
    }

}
