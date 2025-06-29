using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string woodType = GetWood();
            int drawers = GetDrawers();
            double costWood = CalculateWoodCost(woodType);
            double costDrawers = CalculateDrawerCost(drawers);
            double total = CalculateTotalCost(woodType, drawers);

            lblCostWood.Text = costWood.ToString("C");
            lblCostDrawers.Text = costDrawers.ToString("C");
            lblTotalCost.Text = total.ToString("C");
        }
        private string GetWood()
        {
            switch (txtWood.Text.Trim().ToLower())
            {
                case "m": return "mahogany";
                case "o": return "oak";
                case "p": return "pine";
                default: return "other";
            }
        }
        private int GetDrawers()
        {
            if (int.TryParse(txtDrawers.Text, out var n))
                return n;
            return 0;
        }
        private double CalculateWoodCost(string woodType)
        {
            switch (woodType)
            {
                case "mahogany": return 180.0;
                case "oak": return 140.0;
                case "pine": return 100.0;
                default: return 180.0;
            }
        }
        private double CalculateDrawerCost(int numDrawers)
           => numDrawers * 30.0;

        private double CalculateTotalCost(string woodType, int numDrawers)
            => CalculateWoodCost(woodType)
             + CalculateDrawerCost(numDrawers);
    }
}
