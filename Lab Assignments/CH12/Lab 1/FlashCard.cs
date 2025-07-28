using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class FlashCard
    {
        private string _term;
        private string _definition;

        public FlashCard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }
        public string GetTerm()
        {
            return _term;
        }
        public string GetDefinition()
        {
            return _definition;
        }
    }
}
