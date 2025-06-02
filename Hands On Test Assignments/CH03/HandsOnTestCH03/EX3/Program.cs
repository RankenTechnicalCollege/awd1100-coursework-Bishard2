using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Street address: ");
            string street = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip code: ");
            string zip = Console.ReadLine();

            const decimal PRICE_PER_SHIRT = 14.99m;
            Console.Write("Quantity of t-shirts ordered: ");
            int quantity = int.Parse(Console.ReadLine());

            decimal totalPrice = quantity * PRICE_PER_SHIRT;
            decimal salesTax = totalPrice * 0.08m;
            decimal amountDue = totalPrice + salesTax;

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("-------------");
            Console.WriteLine($"Name:     {name}");
            Console.WriteLine($"Address:  {street}");
            Console.WriteLine($"          {city}, {state} {zip}");
            Console.WriteLine();
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Unit Price: {PRICE_PER_SHIRT:C2}");
            Console.WriteLine($"Total Price: {totalPrice:C2}");
            Console.WriteLine($"Sales Tax (8%): {salesTax:C2}");
            Console.WriteLine($"Amount Due:     {amountDue:C2}");
        }
    }
}
