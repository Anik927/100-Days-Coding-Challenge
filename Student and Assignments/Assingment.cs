using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_Assignments
{
    internal class Assignment
    {
        private string title;
        private DateTime dueDate;
        private double score;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public Assignment() { }

        public Assignment(string tittle, DateTime dueDate, double score)
        {
            this.title = tittle;
            this.dueDate = dueDate;
            this.score = score;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Title = " + title);
            Console.WriteLine("Due Date = " + dueDate);
            Console.WriteLine("Score = " + Score);
        }

    }
}
