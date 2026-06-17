using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 5, 2, 1, 4 };
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
