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
        Console.WriteLine("For Loop Example");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        Console.WriteLine("Leap Year Example");
        int year;
        Console.Write("Enter a year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is Not a Leap Year");
        }

        Console.WriteLine("For Loop Continue Examplee");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }

        Console.WriteLine("For Loop Break Examplee");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}
    
