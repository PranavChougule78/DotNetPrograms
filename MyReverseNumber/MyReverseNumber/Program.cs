using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "mom";
            string rev = "";
            
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                rev += str[i];

            }
            Console.WriteLine("Original string:"+str);
            Console.WriteLine("Reversed string:"+rev);

            if (rev == str)
            {
                Console.WriteLine("its palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }



            
        }
    }
}
