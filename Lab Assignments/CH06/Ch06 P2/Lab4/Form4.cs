using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Form
    {
        private int[] numbers = new int[20];
        private int count = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out int n))
            {
                lblError.Text = "Invalid integer";
                return;
            }

            lblError.Text = "";

            if (count < numbers.Length)
            {
                numbers[count++] = n;
                lblCount.Text = $"Numbers Entered: {count}/20";
            }
            else
            {
                MessageBox.Show("Already entered 20 numbers.");
                return;
            }

            CalculateStats(out int min, out int max, out double sum, out double avg, numbers, count);

            lblMin.Text = $"Lowest: {min}";
            lblMax.Text = $"Highest: {max}";
            lblSum.Text = $"Sum: {sum}";
            lblAverage.Text = $"Average: {avg:F1}";
        }
        public void CalculateStats(
            out int min,
            out int max,
            out double sum,
            out double avg,
            int[] numbers,
            int count)
        {
            if (count == 0)
            {
                min = max = 0;
                sum = avg = 0.0;
                return;
            }

            min = max = numbers[0];
            sum = 0.0;

            for (int i = 0; i < count; i++)
            {
                int v = numbers[i];
                if (v < min) min = v;
                if (v > max) max = v;
                sum += v;
            }

            avg = sum / count;
        }
    }
}
