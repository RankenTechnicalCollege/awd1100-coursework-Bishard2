using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Student
    {
        private static int _nextId = 100;

        public int Id { get; private set; }
        public string First { get; private set; }
        public string Last { get; private set; }
        public string Email { get; private set; }

        public Student(string first, string last, string email)
        {
            Id = _nextId++;
            First = first ?? "";
            Last = last ?? "";
            Email = email ?? "";
        }

        public Student(int id, string first, string last, string email)
        {
            Id = id;
            First = first ?? "";
            Last = last ?? "";
            Email = email ?? "";
            if (id >= _nextId) _nextId = id + 1;
        }

        public string FullName
        {
            get { return First + " " + Last; }
        }

        public override string ToString()
        {
            return FullName + " | " + Email + " | ID: " + Id;
        }
    }
}
