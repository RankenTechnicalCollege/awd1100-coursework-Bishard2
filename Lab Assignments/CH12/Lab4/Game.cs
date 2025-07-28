using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Game
    {
        private string _name;
        private string _publisher;
        private float _price;

        public Game(string name, string publisher, float price)
        {
            _name = name;
            _publisher = publisher;
            _price = price;
        }

        public string GetName() => _name;
        public string GetPublisher() => _publisher;
        public float GetPrice() => _price;
    }
}
