using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_LibraryCard
{
    internal class Student
    {

        private int studentID;
        private string name;
        private LibraryCard libraryCard;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public LibraryCard LibraryCard
        {
            get { return libraryCard; }
            set { libraryCard = value; }
        }

        public Student() { }

        public Student(int studentID, string name, LibraryCard libraryCard)
        {
            this.studentID = studentID;
            this.name = name;
            this.libraryCard = libraryCard;
        }

        public void ActiveLibaryCard()
        {
            libraryCard.IsActive = true;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Student Details: ");
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine("LibaryCard Details: ");
            libraryCard.ShowDetails();
        }
        
    }
}
