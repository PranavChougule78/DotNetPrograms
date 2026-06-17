using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    public class Printer
    {
       public virtual void print() 
        {
            Console.WriteLine("Printer working"); 
        }

        public class ColourPrinter : Printer
        {
            public override void print() 
            {
                Console.WriteLine("Colour Printer Working"); 
            }
        }
        public class BlackAndwhitePrinter : Printer
        {
            public void print() { Console.WriteLine("BlackPrinter working"); }

        }
    }
}
