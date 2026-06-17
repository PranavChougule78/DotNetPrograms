using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseifExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 95)
            {
                Console.WriteLine("Destignation");

            }
            else if (marks > 80)
            {
                Console.WriteLine("second class");
            }
            else if(marks > 70)
            {
                Console.WriteLine("Third class");
            }
            else if (marks >=35)
            {
                Console.WriteLine("Pass");
                 
            }
            else if (marks <=35)
            {
                Console.WriteLine("Fail");  
            }

        }
    }
}
