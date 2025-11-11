using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Report_Generation
{
    internal abstract class Report
    {
        protected string reportTitle;
        protected DateTime createdDate;

        public string ReportTitle
        {
            get { return reportTitle; } 
            set { reportTitle = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public Report() { }

        public Report(string reportTitle, DateTime createdDate)
        {
            this.reportTitle = reportTitle;
            this.createdDate = createdDate;
        }

        public abstract string GenerateContent();
        public abstract void PrintReport();

        public void ShowDetails()
        {
            Console.WriteLine("Report Titile: " + reportTitle);
            Console.WriteLine("Created Date: " + createdDate);
        }

    }
}
