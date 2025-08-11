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
        private List<Password> passwordList = new List<Password>();
        public Form1()
        {
            InitializeComponent();
            LoadPasswords();
        }
        private void LoadPasswords()
        {
            passwordList.Add(new Password("123456", "e10adc3949ba59abbe56e057f20f883e"));
            passwordList.Add(new Password("123456789", "25f9e794323b453885f5181f1b624d0b"));
            passwordList.Add(new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"));
            passwordList.Add(new Password("111111", "96e79218965eb72c92a549dd5a330112"));
            passwordList.Add(new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"));
            passwordList.Add(new Password("qwertyuiop", "6eea9b7ef19179a06954edd0c8fc05cb"));
            passwordList.Add(new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"));
            passwordList.Add(new Password("google", "c8221bc3853ed273b89687ac505f9f9a"));
            passwordList.Add(new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"));
            passwordList.Add(new Password("TrUb4dor83", "4ece5736123b52ccffdbe0f821956754"));
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string inputHash = txtHash.Text.Trim().ToLower();
            string result = CrackPassword(inputHash);

            lblResult.Text = string.IsNullOrEmpty(result) ? "* FAIL *" : result;
        }
        private string CrackPassword(string hash)
        {
            foreach (Password p in passwordList)
            {
                if (p.Hash == hash)
                    return p.Raw;
            }
            return null;
        }
    }
}
