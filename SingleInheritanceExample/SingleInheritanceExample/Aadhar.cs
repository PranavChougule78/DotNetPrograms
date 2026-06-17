using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceExample
{
    public class Aadhar
    {
        public string AadharNumber { get; set; }
         public void DisplayAadharInfo()
         {

            Console.WriteLine($"AadharNumber:{AadharNumber}");
          }
    } 
}
