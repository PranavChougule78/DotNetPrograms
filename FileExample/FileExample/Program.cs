using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Tempfile\\example05.txt";
            File.AppendAllText(filePath, "Start Job " + DateTime.Now);

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText(filePath, i.ToString()+"\n ");
            }
            File.AppendAllText(filePath, "End Job " + DateTime.Now);
        }
    }
}
