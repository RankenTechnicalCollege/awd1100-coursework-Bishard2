using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Order
    {
        public Occasion Occasion { get; set; }
        public Style Style { get; set; }

        public bool AddEnvelope { get; set; }
        public bool AddStamp { get; set; }
        public bool AddCustomMessage { get; set; }
        public string CustomMessage { get; set; }

        // Costs (change values here if your rubric wants different cents)
        public const decimal EnvelopeCost = 0.25m;
        public const decimal StampCost = 0.50m;
        public const decimal MessageCost = 0.25m;

        public decimal Total()
        {
            decimal total = 0m;

            if (Style != null) total += Style.BasePrice;
            if (AddEnvelope) total += EnvelopeCost;
            if (AddStamp) total += StampCost;
            if (AddCustomMessage) total += MessageCost;

            return total;
        }
    }
}
