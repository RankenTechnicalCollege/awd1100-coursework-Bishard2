using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Industry
    {
        public string Name { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>();

        public override string ToString() => Name;
    }
}
