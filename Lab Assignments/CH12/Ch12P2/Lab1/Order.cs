using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Order
    {
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        public string Name => _name;
        public Sundae Sundae => _sundae;
        public Soda Soda => _soda;
        public double Price => (_sundae?.Price ?? 0) + (_soda?.Price ?? 0);

        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;
            if (hasSundae) _sundae = new Sundae();
            if (hasSoda) _soda = new Soda();
        }

        public override string ToString()
        {
            string result = $"{_name}: ";

            if (_sundae != null)
                result += $"Sundae ({_sundae}) ${_sundae.Price:F2}; ";
            if (_soda != null)
                result += $"Soda ({_soda}) ${_soda.Price:F2}";

            return result.Trim();
        }
    }
}
