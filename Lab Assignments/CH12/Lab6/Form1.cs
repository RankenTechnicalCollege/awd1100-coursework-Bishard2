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
    public partial class Form1 : Form
    {
        private const int MaxRooms = 20;
        private List<Room> rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rooms.Count >= MaxRooms)
            {
                MessageBox.Show("Maximum number of rooms reached.");
                return;
            }

            string name = txtName.Text.Trim();
            bool validWidth = int.TryParse(txtWidth.Text.Trim(), out int width);
            bool validLength = int.TryParse(txtLength.Text.Trim(), out int length);

            if (string.IsNullOrWhiteSpace(name) || !validWidth || !validLength || width <= 0 || length <= 0)
            {
                MessageBox.Show("Please enter valid name, width, and length.");
                return;
            }

            Room room = new Room(name, width, length);
            rooms.Add(room);

            int totalBoxes = 0;
            string roomSummary = "";

            foreach (Room r in rooms)
            {
                roomSummary += r.Display() + Environment.NewLine;
                totalBoxes += r.Boxes;
            }

            lblRoomCount.Text = $"Rooms: {rooms.Count}/20";
            lblTotalBoxes.Text = $"Total Boxes Needed: {totalBoxes}";
            lblOutput.Text = roomSummary.Trim();

            txtName.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            txtName.Focus();
        }
    }
}
