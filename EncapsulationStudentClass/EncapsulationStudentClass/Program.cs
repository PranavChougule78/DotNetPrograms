using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationStudentClass
{
    using System;

    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();
            s.Name = "Pranav";

            Console.WriteLine("Student Name: " + s.Name);
        }
    }
}
