using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class DecoderRing
    {
        private int _shift;
        private string _outerRing = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _innerRing;

        public int Shift => _shift;

        public DecoderRing(int shift)
        {
            if (shift < 0 || shift > 25)
                throw new FormatException();

            _shift = shift;
            _innerRing = _outerRing.Substring(shift) + _outerRing.Substring(0, shift);
        }

        public string Encode(string text)
        {
            return ConvertText(text, _outerRing, _innerRing);
        }

        public string Decode(string text)
        {
            return ConvertText(text, _innerRing, _outerRing);
        }

        private string ConvertText(string text, string fromRing, string toRing)
        {
            string result = "";

            foreach (char c in text.ToUpper())
            {
                if (c == ' ')
                {
                    result += ' ';
                }
                else if (!fromRing.Contains(c))
                {
                    throw new InvalidCharacterException();
                }
                else
                {
                    int index = fromRing.IndexOf(c);
                    result += toRing[index];
                }
            }

            return result;
        }
    }
}
