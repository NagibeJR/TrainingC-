// A Hello World! Program in C#
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"{name},Hello Word!");

            //Keep the console window open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}