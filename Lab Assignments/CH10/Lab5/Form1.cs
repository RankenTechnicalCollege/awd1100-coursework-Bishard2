using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private readonly Course _course = new Course("AWD 1000 – Student List");

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _course.AddStudent(new Student("Rob", "Smith", "rob.smith@example.com"));
            _course.AddStudent(new Student("Travis", "Irwin", "tirwin@school.edu"));
            _course.AddStudent(new Student("Jia", "Alejandro", "jalejandro@school.edu"));
            _course.AddStudent(new Student("Lia", "Myers", "lmyers@gmail.com"));

            RefreshUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string first = (txtFirst.Text ?? "").Trim();
            string last = (txtLast.Text ?? "").Trim();
            string email = (txtEmail.Text ?? "").Trim();
            string idRaw = (txtID.Text ?? "").Trim();

            if (first.Length == 0 || last.Length == 0 || email.Length == 0)
            {
                MessageBox.Show(
                    "Missing Info: Enter first name, last name, and email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!LooksLikeEmail(email))
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (int.TryParse(idRaw, out id))
                _course.AddStudent(new Student(id, first, last, email));
            else
                _course.AddStudent(new Student(first, last, email));

            ClearAddBoxes();
            RefreshUI();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cboRemove.SelectedItem == null)
            {
                MessageBox.Show("Choose a student to remove.", "Remove",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = cboRemove.SelectedItem as Student;
            if (selected != null)
            {
                _course.RemoveStudentById(selected.Id);
                RefreshUI();
            }
        }

        private void RefreshUI()
        {
            rtbRoster.Text = _course.RosterText();

            cboRemove.DataSource = null;
            cboRemove.DisplayMember = "FullName";
            cboRemove.ValueMember = "Id";
            cboRemove.DataSource = _course.Students
                .OrderBy(s => s.Last)
                .ThenBy(s => s.First)
                .ThenBy(s => s.Id)
                .ToList();
        }

        private void ClearAddBoxes()
        {
            txtID.Text = "";
            txtFirst.Text = "";
            txtLast.Text = "";
            txtEmail.Text = "";
            txtFirst.Focus();
        }

        private bool LooksLikeEmail(string email)
        {
            return Regex.IsMatch(email ?? "",
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
