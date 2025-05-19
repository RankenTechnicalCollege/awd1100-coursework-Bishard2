using System;

class Program
{
    const double KM_PER_MILE = 1.6;

    static void Main()
    {
        Console.Write("Enter a distance in miles: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double miles))
        {
            double kilometers = miles * KM_PER_MILE;
            Console.WriteLine($"{miles:F1} miles is {kilometers:F1} kilometers");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}