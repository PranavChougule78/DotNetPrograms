using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class   BasePrinter
    {

        public abstract void Print();
       
        public void GetPaper()
        {
            Console.WriteLine("Get Paper");
        }
          
        

    
    
        public void ColorPrint()
        {
            Console.WriteLine("Color Printer");
        }
    }
    public class BlackWhitePrinter : BasePrinter
    {
        public override void Print()
        {
            Console.WriteLine("Base Printer");
        }
        public void BlackWhitePrint()
        {
            Console.WriteLine("Black and White Printer");
        }
    }


}
