using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Course { get; }
        public string CourseGrade { get; }
        public double GPA { get; }

        public Student(string first, string last, string course, string courseGrade, double gpa)
        {
            FirstName = first ?? "";
            LastName = last ?? "";
            Course = course ?? "";
            CourseGrade = courseGrade ?? "";
            GPA = gpa;
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
