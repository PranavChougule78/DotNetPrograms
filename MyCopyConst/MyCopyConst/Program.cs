using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CopyConstructorExample
{
    class Student
    {
        int id;
        string name;

        
        public Student(int i, string n)
        {
            id = i;
            name = n;
        }
        

       
        public Student(Student s)
        {
            id = s.id;
            name = s.name;
        }
      

        
        public void Display()
        {
            Console.WriteLine("Student Id: " + id);
            Console.WriteLine("Student Name: " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student(101, "Pranav");

            Student s4 = new Student(102, "Virat");

            Student s5 = new Student(103, "Rajat");

         
            Student s2 = new Student(s1);

            Student s3 = new Student(s4);

            Student student = new Student(s2);

            Console.WriteLine("First Object Data:");
            s1.Display();

            Console.WriteLine();

            Console.WriteLine("Second Object Data:");
            s2.Display();

            Console.WriteLine("Third object Data:");
            s5.Display();

            Console.WriteLine("Fourth object Data:");
            s5.Display();
            Console.ReadLine();
        }
    }
}