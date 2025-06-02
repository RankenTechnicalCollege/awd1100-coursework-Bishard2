using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            double num3 = double.Parse(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"The average is: {average}");
        }
    }
}
