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
        private readonly List<Student> _students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            SeedData();

            txtFirst.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearchFirst.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            txtLast.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearchLast.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            btnSearchFirst.Click += btnSearchFirst_Click;
            btnSearchLast.Click += btnSearchLast_Click;

            ClearResults();
        }

        private void SeedData()
        {
            _students.Add(new Student("Travis", "Irwin", "AWD 1000 L01", "A", 3.5));
            _students.Add(new Student("Maya", "Lopez", "CIS 110", "B+", 3.2));
            _students.Add(new Student("Jamal", "Chen", "NET 230", "A-", 3.7));
            _students.Add(new Student("Priya", "Singh", "DB 210", "B", 3.1));
            _students.Add(new Student("Liam", "Ng", "AWD 120", "A", 3.9));
            _students.Add(new Student("Harper", "Lee", "DB 101", "B-", 2.9));
        }

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            var first = (txtFirst.Text ?? "").Trim();
            if (first.Length == 0)
            {
                ShowNotFound("Enter a first name.");
                return;
            }

            var match = _students
                .FirstOrDefault(stu => string.Equals(stu.FirstName, first, StringComparison.OrdinalIgnoreCase));

            if (match == null) ShowNotFound("Student Not Found");
            else ShowStudent(match);
        }

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            var last = (txtLast.Text ?? "").Trim();
            if (last.Length == 0)
            {
                ShowNotFound("Enter a last name.");
                return;
            }

            var match = _students
                .FirstOrDefault(stu => string.Equals(stu.LastName, last, StringComparison.OrdinalIgnoreCase));

            if (match == null) ShowNotFound("Student Not Found");
            else ShowStudent(match);
        }

        private void ShowStudent(Student s)
        {
            lblStatus.Text = "";

            lblName.Text = s.FullName;
            lblCourse.Text = "Course: " + s.Course;
            lblCourseGrade.Text = "Course Grade: " + s.CourseGrade;
            lblGpa.Text = "GPA: " + s.GPA.ToString("0.0");
        }

        private void ShowNotFound(string msg)
        {
            ClearResults();
            lblStatus.Text = msg;
        }

        private void ClearResults()
        {
            lblStatus.Text = "";
            lblName.Text = "";
            lblCourse.Text = "";
            lblCourseGrade.Text = "";
            lblGpa.Text = "";
        }
    }
}
