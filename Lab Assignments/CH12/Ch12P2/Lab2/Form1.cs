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
        private Conference[] conferences = new Conference[20];
        private int confCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (confCount >= 20)
            {
                lblOutput.Text = "Maximum of 20 conferences reached.";
                return;
            }

            if (!DateTime.TryParse(txtDate.Text, out DateTime date))
            {
                lblOutput.Text = "Invalid date.";
                return;
            }

            if (!int.TryParse(txtAttendees.Text, out int attendees))
            {
                lblOutput.Text = "Invalid number of attendees.";
                return;
            }

            if (!int.TryParse(txtRoom.Text, out int roomNum) || !Enum.IsDefined(typeof(Room), roomNum))
            {
                lblOutput.Text = "Invalid room number.";
                return;
            }

            Room room = (Room)roomNum;

            var conf = new Conference
            {
                GroupName = txtGroupName.Text,
                StartingDate = date,
                Attendees = attendees,
                Room = room
            };

            conferences[confCount++] = conf;
            ClearForm();
            UpdateDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtBegin.Text, out DateTime begin) ||
           !DateTime.TryParse(txtEnd.Text, out DateTime end))
            {
                lblOutput.Text = "Invalid search date range.";
                return;
            }

            var matches = conferences.Take(confCount)
                .Where(c => c.StartingDate >= begin && c.StartingDate <= end)
                .Select(c => c.Display());

            lblOutput.Text = string.Join(Environment.NewLine, matches);
        }

        private void UpdateDisplay()
        {
            lblOutput.Text = string.Join(Environment.NewLine, conferences.Take(confCount).Select(c => c.Display()));
            lblConferences.Text = $"Conferences: {confCount}/20";
            lblTotalAttendees.Text = $"Total Attendees: {conferences.Take(confCount).Sum(c => c.Attendees)}";
        }

        private void ClearForm()
        {
            txtGroupName.Clear();
            txtDate.Clear();
            txtAttendees.Clear();
            txtRoom.Clear();
            txtGroupName.Focus();
        }
    }
}
