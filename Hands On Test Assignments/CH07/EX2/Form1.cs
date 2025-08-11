using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Arithmetic Error: Cannot divide by zero.", "ArithmeticException");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "abc";
                int num = int.Parse(text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Error: Please enter a valid number.", "FormatException");
            }
        }

        private void btnInvalid_Click(object sender, EventArgs e)
        {
            try
            {
                object obj = "hello";
                int num = (int)obj;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Invalid Cast: Cannot convert string to int.", "InvalidCastException");
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            try
            {
                string name = null;
                int len = name.Length;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null Reference: You're trying to use an object that is null.", "NullReferenceException");
            }
        }
    }
}
