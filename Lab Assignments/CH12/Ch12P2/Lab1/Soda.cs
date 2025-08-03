using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Soda
    {
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = 0.15;
        public SodaFlavor Flavor { get; private set; } = SodaFlavor.NONE;

        public double Price => BASE_PRICE + (Flavor == SodaFlavor.NONE ? 0 : FLAVOR_PRICE);

        public void AddFlavor(SodaFlavor flavor)
        {
            Flavor = flavor;
        }

        public override string ToString()
        {
            return Flavor.ToString();
        }
    }
}
