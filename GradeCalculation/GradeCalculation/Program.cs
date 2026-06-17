using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        int marks = 82;

        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}