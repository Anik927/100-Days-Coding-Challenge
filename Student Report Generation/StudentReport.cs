using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Report_Generation
{
    internal class StudentReport:Report
    {
        private string studentName;
        private double averageScore;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public double AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }

        public StudentReport() { }

        public StudentReport(string title, DateTime createdDate, string studentName, double averageScore): base(title, createdDate)
        {
            this.studentName = studentName;
            this.averageScore = averageScore;
        }

        public override string GenerateContent()
        {
            return $"Student name: {studentName} and Avg Score: {averageScore}";
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Report Titile: " + reportTitle);
            Console.WriteLine("Created Date: " + createdDate);
        }

        public override void PrintReport()
        {
            Console.WriteLine("Report:");
            ShowDetails();
            Console.WriteLine(GenerateContent());
        }

    }
}
