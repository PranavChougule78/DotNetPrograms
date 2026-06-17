using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList values = new ArrayList();
            values.Add(1);
            values.Add(2);
            values.Add("pranav");
            values.Add(3.14);
            values.Add(true);

            Console.WriteLine("Total Element: " + values.Count);

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
