using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_Assignments
{
    internal class Student
    {
        private int studentId;
        private string name;
        private List<Assignment> assignments;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Assignment> Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }

        public Student() { }
        public Student(int studentId, string name, List<Assignment> assignments)
        {
            this.studentId = studentId;
            this.name = name;
            this.assignments = assignments ?? new List<Assignment>();
        }

        public List<Assignment> GetPendingAssignments()
        {
            return Assignments.Where(a => a.DueDate > DateTime.Now).ToList();
        }
        
        public void ShowDetails()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Name: " + name);
            int a = 1;
            foreach(Assignment ass in assignments)
            {
                Console.WriteLine($"Assignments no {a++}: ");
                ass.ShowDetails();
            }
            Console.WriteLine();

        }



    }
}
