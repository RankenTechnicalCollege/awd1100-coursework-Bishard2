using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
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
            First = first ?? "";
            Last = last ?? "";
            Email = email ?? "";
            Id = _nextId++;
        }

        public Student(string first, string last, string email, int id)
        {
            First = first ?? "";
            Last = last ?? "";
            Email = email ?? "";
            Id = id;

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
