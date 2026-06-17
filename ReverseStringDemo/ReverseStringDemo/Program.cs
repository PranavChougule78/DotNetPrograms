using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringDemo
{
    using System;

    class Program
    {
        static void Main()
        {
            string name = "PRANAV";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
        }
    }




}
