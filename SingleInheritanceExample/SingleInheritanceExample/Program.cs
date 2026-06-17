using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "John Doe",
                age = 30,
                AadharNumber = "1234-5678-9012"

            };

            Person persson1 = new Person();
            //person1.Name = "Jane smith";
            //person1.Age = 25;
            //person1.AadharNumber = "1234-5678-9012";

            person.DisplayInfo();
            person.DisplayAadharInfo();
        }
    }
}
