using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Amazon");
            company.CompanyDirector();

            Company company1 = new Company("Google");
            company.CompanyDirector();
            
            Company company2 = new Company();
            Console.ReadLine();

            Company company4 = new Company("TCS");
            Console.ReadLine();

            Company company3 = new Company();
            Console.ReadLine();

        }
    }
}
