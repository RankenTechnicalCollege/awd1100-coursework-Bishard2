using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float weight = float.Parse(txtWeight.Text);
                float height = float.Parse(txtHeight.Text);

                Bmi result = BmiCalculator.CalcBmi(weight, height);
                lblOutput.ForeColor = Color.Black;
                lblOutput.Text = $"BMI: {result.BmiValue:F1}\nCategory: {result.WeightCategory}";
            }
            catch (FormatException)
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "INVALID WEIGHT or HEIGHT";
            }
            catch (InvalidWeightException)
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "INVALID WEIGHT";
            }
            catch (InvalidHeightException)
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "INVALID HEIGHT";
            }
        }
    }
}
