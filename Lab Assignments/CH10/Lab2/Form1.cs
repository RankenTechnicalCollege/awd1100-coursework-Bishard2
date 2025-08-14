using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly List<Industry> _industries = new List<Industry>();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            btnSearch.Click += btnSearch_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _industries.Add(new Industry
            {
                Name = "Information Technology",
                Jobs = new List<Job>
                {
                    new Job { Title="Help Desk Technician", Company="TechOne", Location="Remote",
                        Url="https://example.com/jobs/it1" },
                    new Job { Title="Junior Developer", Company="AppWorks", Location="Austin, TX",
                        Url="https://example.com/jobs/it2" }
                }
            });

            _industries.Add(new Industry
            {
                Name = "Mechanical Engineering",
                Jobs = new List<Job>
                {
                    new Job { Title="Quality Engineer - Level I", Company="MachCo", Location="Detroit, MI",
                        Url="https://example.com/jobs/me1" },
                    new Job { Title="Junior Development Engineer", Company="ProtoLab", Location="Cleveland, OH",
                        Url="https://example.com/jobs/me2" }
                }
            });

            _industries.Add(new Industry
            {
                Name = "Chemical Engineering",
                Jobs = new List<Job>
                {
                    new Job { Title="Junior Chemical Engineer", Company="Chemix", Location="Baton Rouge, LA",
                        Url="https://example.com/jobs/ce1" }
                }
            });

            _industries.Add(new Industry
            {
                Name = "HVAC",
                Jobs = new List<Job>
                {
                    new Job { Title="HVAC Installer", Company="AirPro", Location="Phoenix, AZ",
                        Url="https://example.com/jobs/hvac1" }
                }
            });

            _industries.Add(new Industry
            {
                Name = "Automotive",
                Jobs = new List<Job>
                {
                    new Job { Title="Software Architect", Company="DriveSoft", Location="Dearborn, MI",
                        Url="https://example.com/jobs/auto1" }
                }
            });

            lstIndustries.Items.Clear();
            foreach (var ind in _industries)
                lstIndustries.Items.Add(ind);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedIndustries = new List<Industry>();
            foreach (var item in lstIndustries.SelectedItems)
            {
                var ind = item as Industry;
                if (ind != null) selectedIndustries.Add(ind);
            }

            var results = new List<Job>();
            foreach (var ind in selectedIndustries)
                results.AddRange(ind.Jobs);

            if (results.Count == 0)
            {
                MessageBox.Show("Select one or more industries that have jobs.", "No Results",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frm = new ResultsForm(results);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
