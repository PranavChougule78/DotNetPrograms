using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstExample
{
    public class Company
    {
        public Company()
        {
            Console.WriteLine("Company created");

        }
        public Company(string sisterCompanyName)

        {
            Console.WriteLine($"Company created with name:{sisterCompanyName}");
        }
       
        public void CompanyDirector()
        {
            Console.WriteLine("Director list");
        }
    }
}
