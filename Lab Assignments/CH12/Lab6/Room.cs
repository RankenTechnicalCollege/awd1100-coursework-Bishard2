using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = _width * _length;

            _boxes = (_area / 12);
            if (_area % 12 != 0)
                _boxes++;

            _boxes++;
        }

        public string Name => _name;
        public int Width => _width;
        public int Length => _length;
        public int Area => _area;
        public int Boxes => _boxes;

        public string Display()
        {
            return $"{_name} ({_width}x{_length}) needs {_boxes} boxes";
        }
    }
}
