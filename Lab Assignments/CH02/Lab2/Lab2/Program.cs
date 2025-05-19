using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Student Grade Average Calculator");
        double total = 0;
        const int NUM_SCORES = 4;

        for (int i = 1; i <= NUM_SCORES; i++)
        {
            Console.Write($"Enter test score #{i}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double score))
            {
                total += score;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a numeric score.");
                i--; // repeat this iteration
            }
        }

        double average = total / NUM_SCORES;
        Console.WriteLine($"\nThe average of the four test scores is {average:F2}.");
    }
}
