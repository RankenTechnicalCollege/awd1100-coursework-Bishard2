using System;
using System.Globalization;

namespace HomeSalesTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalDanielle = 0m;
            decimal totalEdward = 0m;
            decimal totalFrancis = 0m;

            while (true)
            {
                Console.Write("Who made the sale? ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid initial");
                    continue;
                }

                string initial = input.ToLowerInvariant();

                if (initial == "z")
                {
                    break;
                }
                else if (initial == "d" || initial == "e" || initial == "f")
                {
                    Console.Write("How much was the sale? ");
                    string amtInput = Console.ReadLine()?.Trim();
                    if (!decimal.TryParse(amtInput, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal saleAmount)
                        || saleAmount < 0m)
                    {
                        Console.WriteLine("Invalid sale amount");
                        continue;
                    }

                    switch (initial)
                    {
                        case "d":
                            totalDanielle += saleAmount;
                            break;
                        case "e":
                            totalEdward += saleAmount;
                            break;
                        case "f":
                            totalFrancis += saleAmount;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid initial");
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Danielle Sales: {totalDanielle:C2}");
            Console.WriteLine($"Edward Sales: {totalEdward:C2}");
            Console.WriteLine($"Francis Sales: {totalFrancis:C2}");
            Console.WriteLine();

            decimal grandTotal = totalDanielle + totalEdward + totalFrancis;
            Console.WriteLine($"Grand Total: {grandTotal:C2}");

            string topSalesperson;
            decimal topAmount = totalDanielle;
            topSalesperson = "Danielle";

            if (totalEdward > topAmount)
            {
                topAmount = totalEdward;
                topSalesperson = "Edward";
            }
            if (totalFrancis > topAmount)
            {
                topAmount = totalFrancis;
                topSalesperson = "Francis";
            }

            Console.WriteLine($"{topSalesperson} has the most sales");

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
