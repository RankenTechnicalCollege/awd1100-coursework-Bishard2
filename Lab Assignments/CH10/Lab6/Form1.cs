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

namespace Lab6
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
            _course.AddStudent(new Student("Rob", "Smith", "rob.smith@example.com", 1111));
            _course.AddStudent(new Student("Travis", "Irwin", "tirwin@school.edu", 1112));
            _course.AddStudent(new Student("Jia", "Alejandro", "jalejandro@school.edu", 1113));
            _course.AddStudent(new Student("Lia", "Myers", "lmyers@gmail.com", 1115));

            RefreshUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var first = (txtFirst.Text ?? "").Trim();
            var last = (txtLast.Text ?? "").Trim();
            var email = (txtEmail.Text ?? "").Trim();

            if (first.Length == 0 || last.Length == 0 || email.Length == 0)
            {
                MessageBox.Show("Enter first name, last name, and email.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!LooksLikeEmail(email))
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student toAdd;
            int id;
            var idRaw = (txtId.Text ?? "").Trim();
            if (idRaw.Length > 0 && int.TryParse(idRaw, out id))
                toAdd = new Student(first, last, email, id);
            else
                toAdd = new Student(first, last, email);

            bool duplicate = _course.Students.Any(x =>
                x.Id == toAdd.Id ||
                string.Equals(x.Email, toAdd.Email, StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                MessageBox.Show("Duplicate ID or email. Student not added.", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _course.AddStudent(toAdd);
            ClearAddBoxes();
            RefreshUI();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearchById();
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
            private void DoSearchById()
        {
            lblResult.Text = "";

            var raw = (txtSearchId.Text ?? "").Trim();
            int id;
            if (!int.TryParse(raw, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var s = _course.Students.FirstOrDefault(stu => stu.Id == id);
            if (s == null)
            {
                lblResult.Text = "Student Not Found";
                return;
            }

            lblResult.Text = s.FullName + "'s email address is " + s.Email +
                                   " and ID# is " + s.Id;
        }

        private void RefreshUI()
        {
            rtbRoster.Text = _course.RosterText();

            cboRemove.DataSource = null;
            cboRemove.DisplayMember = "FullName";
            cboRemove.ValueMember = "Id";
            cboRemove.DataSource = _course.Students
                .OrderBy(s => s.Last).ThenBy(s => s.First).ThenBy(s => s.Id)
                .ToList();

        }

        private void ClearAddBoxes()
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtEmail.Text = "";
            if (txtId != null) txtId.Text = "";
            txtFirst.Focus();
        }

        private bool LooksLikeEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
