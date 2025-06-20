using System;

namespace TestScoresStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0.0;
            int minScore = int.MaxValue;
            int maxScore = int.MinValue;

            while (true)
            {
                Console.Write("Please enter a test score: ");
                string input = Console.ReadLine()?.Trim();
                if (!int.TryParse(input, out int score))
                {
                    Console.WriteLine("Invalid score");
                    continue;
                }

                if (score == 999)
                {
                    break;
                }

                if (score >= 0 && score <= 100)
                {
                    count++;
                    sum += score;
                    if (score < minScore) minScore = score;
                    if (score > maxScore) maxScore = score;
                }
                else
                {
                    Console.WriteLine("Invalid score");
                }
            }

            Console.WriteLine(); // blank line before results

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Number of scores: {count}");
                Console.WriteLine($"Sum of test scores: {sum:F1}");
                Console.WriteLine($"Average test score: {average:F1}");
                Console.WriteLine($"Lowest test score: {minScore:F1}");
                Console.WriteLine($"Highest test score: {maxScore:F1}");
            }
            else
            {
                Console.WriteLine("No valid scores were entered.");
            }

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}