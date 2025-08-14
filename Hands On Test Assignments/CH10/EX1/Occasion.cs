using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Occasion
    {
        public string Name { get; }
        public List<Style> Styles { get; }

        public Occasion(string name, IEnumerable<Style> styles)
        {
            Name = name ?? "Occasion";
            Styles = new List<Style>(styles ?? new List<Style>());
        }

        public override string ToString() => Name;
    }
}
