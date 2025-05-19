using System;

class Program
{
    const double PERCENT_RAISE = 0.04;

    static void Main()
    {
        const int NUM_EMPLOYEES = 3;
        string[] names = new string[NUM_EMPLOYEES];
        double[] current = new double[NUM_EMPLOYEES];
        double[] year1 = new double[NUM_EMPLOYEES];
        double[] year2 = new double[NUM_EMPLOYEES];

        for (int i = 0; i < NUM_EMPLOYEES; i++)
        {
            Console.Write($"Enter name for employee #{i + 1}: ");
            names[i] = Console.ReadLine();

            Console.Write($"Enter current salary for {names[i]}: ");
            while (!double.TryParse(Console.ReadLine(), out current[i]))
            {
                Console.Write("Invalid salary. Please enter a numeric value: ");
            }

            year1[i] = current[i] * (1 + PERCENT_RAISE);
            year2[i] = year1[i] * (1 + PERCENT_RAISE);
            Console.WriteLine();
        }

        Console.WriteLine("Projected Salaries Over 2 Years\n");
        Console.WriteLine("{0,-20} {1,15} {2,15} {3,15}", "Employee", "Current", "After 1 Year", "After 2 Years");
        Console.WriteLine(new string('-', 70));

        for (int i = 0; i < NUM_EMPLOYEES; i++)
        {
            Console.WriteLine(
                "{0,-20} {1,15:C2} {2,15:C2} {3,15:C2}",
                names[i], current[i], year1[i], year2[i]
            );
        }
    }
}
