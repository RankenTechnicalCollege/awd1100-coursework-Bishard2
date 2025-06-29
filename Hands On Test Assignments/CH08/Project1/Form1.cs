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

namespace Project1
{
    public partial class Form1 : Form
    {
        private List<string> firstNames = new List<string>
            { "Markel", "Luiza",  "Bryony",  "Giraldo", "Lowri" };
        private List<string> lastNames = new List<string>
            { "Diggory","Gunnar", "Hester",  "Addy",    "Hari"  };
        private List<string> phoneNumbers = new List<string>
            { "555-8390","555-4618","555-4440","555-1687","555-7763" };
        public Form1()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            bool found = false;

            lblError.Visible = false;
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblPhone.Text = "";

            for (int i = 0; i < firstNames.Count; i++)
            {
                if (firstNames[i].ToLower().Contains(query)
                 || lastNames[i].ToLower().Contains(query))
                {
                    lblFirstName.Text = firstNames[i];
                    lblLastName.Text = lastNames[i];
                    lblPhone.Text = phoneNumbers[i];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblError.Visible = true;
                lblError.Text = "User Not Found";
                lblFirstName.Text = "error";
                lblLastName.Text = "error";
                lblPhone.Text = "error";
            }
        }
    }
}
