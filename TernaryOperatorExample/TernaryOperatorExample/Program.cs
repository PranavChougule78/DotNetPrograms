using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorExample
    using System;

class Program
{
    static void Main()
    {
        int number = 10;

        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";

        Console.WriteLine(result);
    }
}