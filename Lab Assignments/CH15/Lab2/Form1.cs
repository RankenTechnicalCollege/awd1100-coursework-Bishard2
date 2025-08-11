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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float width = float.Parse(txtWidth.Text);
            float height = float.Parse(txtHeight.Text);
            Photo photo;

            if (rbUnframed.Checked)
            {
                photo = new Photo(width, height);
            }
            else if (rbMatted.Checked)
            {
                Color selectedColor;
                if (rbBlack.Checked) selectedColor = Color.BLACK;
                else if (rbRed.Checked) selectedColor = Color.RED;
                else if (rbGreen.Checked) selectedColor = Color.GREEN;
                else if (rbBlue.Checked) selectedColor = Color.BLUE;
                else if (rbWhite.Checked) selectedColor = Color.WHITE;
                else
                {
                    MessageBox.Show("Please select a matte color.");
                    return;
                }

                photo = new MattedPhoto(width, height, selectedColor);
            }
            else
            {
                Material selectedMaterial;
                Style selectedStyle;

                if (rbPine.Checked) selectedMaterial = Material.PINE;
                else if (rbOak.Checked) selectedMaterial = Material.OAK;
                else if (rbSteel.Checked) selectedMaterial = Material.STEEL;
                else if (rbSilver.Checked) selectedMaterial = Material.SILVER;
                else if (rbGold.Checked) selectedMaterial = Material.GOLD;
                else
                {
                    MessageBox.Show("Please select a frame material.");
                    return;
                }

                if (rbSimple.Checked) selectedStyle = Style.SIMPLE;
                else if (rbModern.Checked) selectedStyle = Style.MODERN;
                else if (rbAntique.Checked) selectedStyle = Style.ANTIQUE;
                else if (rbVintage.Checked) selectedStyle = Style.VINTAGE;
                else if (rbEclectic.Checked) selectedStyle = Style.ECLECTIC;
                else
                {
                    MessageBox.Show("Please select a frame style.");
                    return;
                }

                photo = new FramedPhoto(width, height, selectedMaterial, selectedStyle);
            }

            lblCost.Text = photo.Price.ToString("C");
            lblOutput.Text = photo.ToString();
        }
    }
}
public enum Color { BLACK = 0, RED = 1, GREEN = 2, BLUE = 4, WHITE = 7 }
public enum Material { PINE = 0, OAK = 1, STEEL = 2, SILVER = 3, GOLD = 4 }
public enum Style { SIMPLE = 0, MODERN = 1, ANTIQUE = 2, VINTAGE = 3, ECLECTIC = 4 }
