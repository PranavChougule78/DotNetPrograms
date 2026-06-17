using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Accountholder
{
  internal class Program
    {
        static void Main(string[] args)
        {
           Credit credit = new Credit();
            credit.CreditAmount();
            credit.DebitAmount();
          
            Mypin pin= new Mypin();
            pin.ShowPin();

        }

    }
}
