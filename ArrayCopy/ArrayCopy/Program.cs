using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[3];
            Array.Copy(arr1, arr2, 3);
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
