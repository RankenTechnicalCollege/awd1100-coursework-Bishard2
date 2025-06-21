using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = ReadPositiveInt("How many rows should the table have?");
            int cols = ReadPositiveInt("How many columns should the table have?");

            int maxProduct = rows * cols;
            int cellWidth = maxProduct.ToString().Length;
            cellWidth += 1;

            Console.Write(new string(' ', cellWidth));
            Console.Write("|");
            for (int j = 1; j <= cols; j++)
            {
                Console.Write($"{j.ToString().PadLeft(cellWidth)}|");
            }
            Console.WriteLine();

            Console.Write(new string('-', cellWidth));
            Console.Write("+");
            for (int j = 1; j <= cols; j++)
            {
                Console.Write(new string('-', cellWidth));
                Console.Write("+");
            }
            Console.WriteLine();

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(i.ToString().PadLeft(cellWidth));
                Console.Write("|");
                for (int j = 1; j <= cols; j++)
                {
                    int product = i * j;
                    Console.Write(product.ToString().PadLeft(cellWidth));
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static int ReadPositiveInt(string promptText)
        {
            int result;
            while (true)
            {
                Console.WriteLine(promptText);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (!int.TryParse(input, out result) || result <= 0)
                {
                    Console.WriteLine("  Invalid input. Please enter a positive integer.");
                    continue;
                }
                return result;
            }
        }
    }
}
