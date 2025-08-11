using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                int shift = int.Parse(txtShift.Text);
                DecoderRing ring = new DecoderRing(shift);
                string message = txtEncode.Text;
                string result = ring.Encode(message);
                txtDecode.ForeColor = Color.Black;
                txtDecode.Text = result;
            }
            catch (FormatException)
            {
               lblShiftError.ForeColor = Color.Red;
                lblShiftError.Text = "Invalid shift";
            }
            catch (InvalidCharacterException)
            {
                lblEncodeError.ForeColor = Color.Red;
                lblEncodeError.Text = "Invalid characters in message";
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                int shift = int.Parse(txtShift.Text);
                DecoderRing ring = new DecoderRing(shift);
                string message = txtDecode.Text;
                string result = ring.Decode(message);
                txtEncode.ForeColor = Color.Black;
                txtEncode.Text = result;
            }
            catch (FormatException)
            {
                lblShiftError.ForeColor = Color.Red;
                lblShiftError.Text = "Invalid shift";
            }
            catch (InvalidCharacterException)
            {
                lblDecodeError.ForeColor = Color.Red;
                lblDecodeError.Text = "Invalid characters in message";
            }
        }
    }
}
