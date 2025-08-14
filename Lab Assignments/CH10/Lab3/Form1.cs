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
    public partial class Form1 : Form
    {
        private TextBox[] _boxes;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            _boxes = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8 };

            foreach (var tb in _boxes)
            {
                tb.Enter += TextBox_Enter;
                tb.Leave += TextBox_Leave;
                tb.Click += TextBox_Click;
                tb.KeyDown += TextBox_KeyDown;
                tb.BackColor = Color.LightGray;
            }

            this.KeyDown += Form1_KeyDown;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null) tb.BackColor = Color.Yellow;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null) tb.BackColor = Color.LightBlue;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null) tb.BackColor = Color.LightGray;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            HandleArrows(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            HandleArrows(e);
        }

        private void HandleArrows(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txt1.Focus(); e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                txt3.Focus(); e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                txt5.Focus(); e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                txt7.Focus(); e.Handled = true;
            }
        }
    }
}
