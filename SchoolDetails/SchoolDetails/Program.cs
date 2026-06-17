using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace SchoolDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.display();
            Console.ReadLine();
        }
    }
}
