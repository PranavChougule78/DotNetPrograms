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
        Console.WriteLine("*************For Loop stars Example************\n");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" *");
            }
            
            Console.WriteLine();
        }

        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\n***************Do While stars Example*********************\n");

        int k = 1;

        do
        {
            int j = 1;

            do
            {
                Console.Write(" *");
                j++;
            }
            while (j <= k);
            {
                Console.WriteLine();
                k++;

            }
      
       


    }

}