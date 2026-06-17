using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Accountholder
{
    public partial class Credit
    {
        public Credit()
        {
            Console.WriteLine("Credit class constructor");
        }
        public void CreditAmount()
        {
            Console.WriteLine("Credit Amount is 1000");
        }
    }
public partial class Credit
{
    public Credit(string g)
    {

        Console.WriteLine("Credit class constructor");
    }
    public void DebitAmount()
    {
        Console.WriteLine("Debit amount is 500");
    }
  }
}
public partial class Credit
{
    public Credit(string h)
    {
        Console.WriteLine("Credit class constructor");
    }

    public void TotalDebitAmount()
    {
        Console.WriteLine("TotalDebitAmount is 1500");
    }
}
