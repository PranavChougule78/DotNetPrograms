using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountEncapsulation
{
    
       using System;

class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }
    }

    class Program
    {   
        static void Main()
        {
            BankAccount acc = new BankAccount();
            acc.Balance = 26000;
                

            Console.WriteLine("Balance: " + acc.Balance);
          
        }
    }
}

