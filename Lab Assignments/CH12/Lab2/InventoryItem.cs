using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class InventoryItem
    {
        private string _itemName;
        private int _upc;
        private decimal _price;
        private decimal _costPerCase;
        private int _unitsPerCase;
        private string _distributor;
        public InventoryItem(string itemName, int upc, decimal price, decimal costPerCase, int unitsPerCase, string distributor)
        {
            _itemName = itemName;
            _upc = upc;
            _price = price;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
            _distributor = distributor;
        }

        public string getItemName()
        {
            return _itemName;
        }

        public void setItemName(string name)
        {
            _itemName = name;
        }

        public int getUpc()
        {
            return _upc;
        }

        public void setUpc(int upc)
        {
            _upc = upc;
        }

        public decimal getPrice()
        {
            return _price;
        }

        public void setPrice(decimal price)
        {
            _price = price;
        }

        public decimal getCostPerCase()
        {
            return _costPerCase;
        }

        public void setCostPerCase(decimal cost)
        {
            _costPerCase = cost;
        }

        public int getUnitsPerCase()
        {
            return _unitsPerCase;
        }

        public void setUnitsPerCase(int units)
        {
            _unitsPerCase = units;
        }
        public string getDistributor()
        {
            return _distributor;
        }
        public void setDistributor(string distributor)
        {
            _distributor= distributor;
        }
    }
}
