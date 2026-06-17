using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyCtorExample
{
  
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Person person = new Person(age, name);
            Person person1 = new Person(person);

            person1.DisplayPerso();
        }
    }

}      

