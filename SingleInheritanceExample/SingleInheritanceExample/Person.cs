using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceExample
{
    public class Person : Aadhar
    {
        public string Name { get; set; }
        public int age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age :{age} ");
        }
    }
}
