using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        private const decimal PERCENT_RAISE = 1.04m;

        public Form3()
        {
            InitializeComponent();
            dataResults.Rows.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dataResults.Rows.Clear();

            if (!TryGetEmployee(txtName1.Text.Trim(), txtSalary1.Text.Trim(), out string name1, out decimal sal1)) return;
            if (!TryGetEmployee(txtName2.Text.Trim(), txtSalary2.Text.Trim(), out string name2, out decimal sal2)) return;
            if (!TryGetEmployee(txtName3.Text.Trim(), txtSalary3.Text.Trim(), out string name3, out decimal sal3)) return;

            AddRowToResults(name1, sal1);
            AddRowToResults(name2, sal2);
            AddRowToResults(name3, sal3);
        }
        private bool TryGetEmployee(string nameText, String salaryText, out string name, out decimal salary)
        {
            name = null;
            salary = 0m;

            if (string.IsNullOrEmpty(nameText))
            {
                MessageBox.Show("Please enter the employee's name.", "Input needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FocusTextBoxByName(nameText);
                return false;
            }
            name = nameText;

            if (!decimal.TryParse(salaryText, out salary) || salary < 0m)
            {
                MessageBox.Show($"Enter a valid non-negative salary for {name}.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusTextBoxBySalary(salaryText);
                return false;
            }
            return true;
        }
        private void FocusTextBoxByName(string text)
        {
            if (txtName1.Text.Trim() == text) txtName1.Focus();
            else if (txtName2.Text.Trim() == text) txtName2.Focus();
            else if (txtName3.Text.Trim() == text) txtName3.Focus();
        }
        private void FocusTextBoxBySalary(string text)
        {
            if (txtSalary1.Text.Trim() == text) txtSalary1.Focus();
            else if (txtSalary2.Text.Trim() == text) txtSalary2.Focus();
            else if (txtSalary3.Text.Trim() == text) txtSalary3.Focus();
        }
        private void AddRowToResults(string name, decimal currentSalary)
        {
            decimal after1 = currentSalary * PERCENT_RAISE;
            decimal after2 = after1 * PERCENT_RAISE;
            dataResults.Rows.Add(name, currentSalary, after1, after2);
        }

        private void dataResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
