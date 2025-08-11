using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
        public class Order
        {
            private short _itemNumber;
            private byte _quantity;
            private byte _estimatedDeliveryDays;

            public Order(short itemNumber, byte quantity, byte estimatedDeliveryDays)
            {
                if (itemNumber < 100 || itemNumber > 999)
                    throw new InvalidItemNumberException();
                if (quantity < 1 || quantity > 12)
                    throw new InvalidQuantityException();
                if (estimatedDeliveryDays < 1 || estimatedDeliveryDays > 30)
                    throw new InvalidDeliveryDaysException();

                _itemNumber = itemNumber;
                _quantity = quantity;
                _estimatedDeliveryDays = estimatedDeliveryDays;
            }

            public short ItemNumber { get => _itemNumber; set => _itemNumber = value; }
            public byte Quantity { get => _quantity; set => _quantity = value; }
            public byte EstimatedDeliveryDays { get => _estimatedDeliveryDays; set => _estimatedDeliveryDays = value; }
        }
        public class InvalidItemNumberException : ArgumentException { }
        public class InvalidQuantityException : ArgumentException { }
        public class InvalidDeliveryDaysException : ArgumentException { }
    }
