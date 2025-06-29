using System.Globalization;

class ShoppingCartCalculator
{
    static void Main()
    {
        const decimal TAX_RATE = 0.08m;
        List<decimal> prices = new List<decimal>();

        while (true)
        {
            Console.Write("{0:D2}: ", prices.Count + 1);
            string input = Console.ReadLine().Trim();
            if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
            {
                Console.WriteLine("INVALID PRICE");
                continue;
            }
            if (price < 0)
            {
                Console.WriteLine("INVALID PRICE");
                continue;
            }
            if (price == 0)
            {
                break;
            }
            prices.Add(price);
        }
        int itemCount = prices.Count;
        decimal subtotal = 0m;
        foreach (var p in prices) subtotal += p;

        decimal average = itemCount > 0
            ? subtotal / itemCount
            : 0m;

        decimal tax = subtotal * TAX_RATE;
        decimal total = subtotal + tax;

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Items Purchased: {0}", itemCount);
        Console.WriteLine("Average Item Price: {0:C2}", average);
        Console.WriteLine("Subtotal: {0:C2}", subtotal);
        Console.WriteLine("Tax:      {0:C2}", tax);
        Console.WriteLine("Total:    {0:C2}", total);
    }
}