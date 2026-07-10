using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClassExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string directoryPath = "D:\\TempFile\\24 June";

            for (int i = 0; i<=5; i++)

                string folderName
            {
                Directory.CreateDirectory(directoryPath);
            }





            //if (Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}



            //if (Directory.Exists(filePath))
            //{
            //    string[] allFiles = Directory.GetFiles(filePath);
            //    int count = Directory.GetFiles(filePath).Length;
            //    Console.WriteLine("Total File :" + count);

            //    foreach (string file in allFiles)
            //    {
            //        Console.WriteLine(file);
            //    }
            //}
           
        }
    }
}
