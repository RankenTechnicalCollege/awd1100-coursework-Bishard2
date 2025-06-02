using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your full name: ");
            string yourName = Console.ReadLine();

            Console.WriteLine($"Hello, {yourName}!");
        }
    }
}
