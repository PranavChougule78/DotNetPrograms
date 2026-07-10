using System;

namespace DelegateExample
{
    // Step 1: Declare a delegate
    public delegate void MyDelegate();

    class Program
    {
        // Step 2: Create a method
        public static void Display()
        {
            Console.WriteLine("Hello, Welcome to Delegates in C#");
        }

        static void Main(string[] args)
        {
            // Step 3: Create delegate object and assign method
            MyDelegate obj = new MyDelegate(Display);

            // Step 4: Invoke delegate
            obj();

            Console.ReadLine();
        }
    }
}