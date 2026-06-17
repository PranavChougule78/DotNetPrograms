using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 20;
                int b = 20;
                int result = a / b;
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Handled" +ex.Message);
            }
            finally
            {
                Console.WriteLine("final f1");
            }
          
        }
    }
}
