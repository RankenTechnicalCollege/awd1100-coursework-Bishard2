using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Computer
    {
        private string _name;
        private string _ipAddress;
        private int[] _services;

        public Computer(string name, string ipAddress, int[] services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string Name => _name;
        public string IpAddress => _ipAddress;
        public int[] Services => _services;
    }
}
