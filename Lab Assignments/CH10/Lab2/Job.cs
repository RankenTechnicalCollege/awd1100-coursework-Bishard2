using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Job
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            // What appears in the results list
            return string.Format("{0} — {1} ({2})", Title, Company, Location);
        }
    }
}
