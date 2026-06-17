using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 12.4f;
            Console.WriteLine(value);

            double value2 = 12.3455555555555;
            Console.WriteLine(value2);

            decimal value3 = 34455555.345443435443554455555555555m;
            Console.WriteLine(value3);

            bool submitflag;
            submitflag = true;
            Console.WriteLine(submitflag);

            char name;
            name = 'p';
            Console.WriteLine(name);

            Price price = new Price();
            Console.WriteLine(price.Getprice());

            DateTime current= DateTime.Now;
            Console.WriteLine(current);

         
        }
    }
}
