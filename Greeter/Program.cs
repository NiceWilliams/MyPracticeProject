using System;

namespace Greeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter your name here");
            input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!!");

            Console.WriteLine("Goodybye, " + input + ".");
        }
    }
}
