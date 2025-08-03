using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Sundae
    {
        public const double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = 0.50;
        private List<SundaeTopping> toppings = new List<SundaeTopping>();

        public int ToppingCount => toppings.Count;
        public double Price => BASE_PRICE + toppings.Count * TOPPING_PRICE;

        public void AddTopping(SundaeTopping topping)
        {
            if (toppings.Count < 2 && topping != SundaeTopping.NONE)
                toppings.Add(topping);
        }

        public SundaeTopping GetTopping(int index)
        {
            return index < toppings.Count ? toppings[index] : SundaeTopping.NONE;
        }

        public override string ToString()
        {
            return toppings.Count > 0 ? string.Join(" ", toppings) : "NONE";
        }
    }
}
