using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyCtorExample
{
    public class Person
    {
        public int age;
        public string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Person(Person person)
        {
            age = person.age;
            name = person.name;
        }
        public void PrintPerson()
        {
            Console.WriteLine("This person age is"+ age + " "+"Name called"+name);
        }
        public void DisplayPerso ()
        {
            PrintPerson();
        }
    }   }
