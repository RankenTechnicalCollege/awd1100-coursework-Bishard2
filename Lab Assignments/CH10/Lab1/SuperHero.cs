using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class SuperHero
    {
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Power { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string WikiUrl { get; set; }

        public override string ToString() => Name;
    }
}
