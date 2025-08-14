using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ResultsForm : Form
    {
        private readonly List<Job> _jobs;
        public ResultsForm(List<Job> jobs)
        {
            InitializeComponent();
            _jobs = jobs ?? new List<Job>();
            Load += ResultsForm_Load;
            lstResults.DoubleClick += lstResults_DoubleClick;
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            foreach (var job in _jobs)
                lstResults.Items.Add(job);
        }
        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            var job = lstResults.SelectedItem as Job;
            if (job == null || string.IsNullOrWhiteSpace(job.Url)) return;

            try
            {
                Process.Start(job.Url);
            }
            catch
            {
                try
                {
                    var psi = new ProcessStartInfo();
                    psi.FileName = job.Url;
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
                catch
                {
                    MessageBox.Show("Could not open the job link.", "Open Link",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
