using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
{ 

class Program
{
    static void Main()
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }


        }
    }
}
}