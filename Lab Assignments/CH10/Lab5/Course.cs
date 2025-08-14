using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Course
    {
        public string Name { get; private set; }
        public List<Student> Students { get; private set; }

        public Course(string name)
        {
            Name = name ?? "Untitled Course";
            Students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            if (s == null) return;

            bool exists = Students.Exists(x =>
                string.Equals(x.Email, s.Email, StringComparison.OrdinalIgnoreCase) ||
                x.Id == s.Id);

            if (!exists) Students.Add(s);
        }

        public bool RemoveStudentById(int id)
        {
            var item = Students.FirstOrDefault(s => s.Id == id);
            if (item == null) return false;

            Students.Remove(item);
            return true;
        }

        public string RosterText()
        {
            if (Students.Count == 0) return "(no students added yet)";

            var sb = new StringBuilder();
            foreach (var s in Students.OrderBy(s => s.Last).ThenBy(s => s.First).ThenBy(s => s.Id))
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }
    }
}
