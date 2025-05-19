using System;

class Program
{
    const double DAILY_RATE = 100.0;
    const double PER_MILE_RATE = 0.50;

    static void Main()
    {
        Console.WriteLine("Car Rental Fee Calculator");

        Console.Write("Enter number of days rented: ");
        int days;
        while (!int.TryParse(Console.ReadLine(), out days) || days < 0)
        {
            Console.Write("Invalid entry. Please enter a non-negative integer for days: ");
        }

        Console.Write("Enter miles driven: ");
        double miles;
        while (!double.TryParse(Console.ReadLine(), out miles) || miles < 0)
        {
            Console.Write("Invalid entry. Please enter a non-negative number for miles: ");
        }

        double totalFee = (days * DAILY_RATE) + (miles * PER_MILE_RATE);

        Console.WriteLine($"\nTotal rental fee: ${totalFee:F2}");
    }
}
