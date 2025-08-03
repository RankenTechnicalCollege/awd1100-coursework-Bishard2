using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string inputHash = txtHash.Text.Trim().ToLower();

            Dictionary<string, string> rainbowTable = new Dictionary<string, string>()
            {
                { "e10adc3949ba59abbe56e057f20f883e", "123456" },
                { "25f9e794323b453885f5181f1b624d0b", "123456789" },
                { "d8578edf8458ce06fbc5bb76a58c5ca4", "qwerty" },
                { "96e79218965eb72c92a549dd5a330112", "111111" },
                { "5f4dcc3b5aa765d61d8327deb882cf99", "password" },
                { "6eea9b7ef19179a06954edd0f6c05ceb", "qwertyuiop" },
                { "c8837b23ffbaa8a2dde915473ce0991", "123321" },
                { "c822c1b63853ed273b89687ac585f9fa", "google" },
                { "161ebd7d45089b3446ee4e8dd6bdcfc2", "P@ssw0rd" },
                { "4ece57a61323b52ccfdfbef021956754", "Tr0ub4dor&3" }
            };

            if (rainbowTable.ContainsKey(inputHash))
            {
                lblResult.Text = "Password: " + rainbowTable[inputHash];
            }
            else
            {
                lblResult.Text = "* FAIL *";
            }
        }
    }
}
