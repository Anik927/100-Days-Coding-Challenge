using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_LibraryCard
{
    internal class LibraryCard
    {

        private string cardNumber;
        private DateTime issueDate;
        private bool isActive;

        public string CardNumber
        {
            get { return cardNumber; } 
            set {  cardNumber = value; }
        }

        public DateTime IssueDate
        { 
            get { return issueDate; } 
            set { issueDate = value; } 
        }

        public bool IsActive
        {
            get { return isActive; } 
            set {  isActive = value; }
        }

        public LibraryCard() { }

        public LibraryCard(string cardNumber, DateTime issueDate, bool isActive)
        {
            this.cardNumber = cardNumber;
            this.issueDate = issueDate;
            this.isActive = isActive;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Card Number: {cardNumber}");
            Console.WriteLine($"Issue Date: {issueDate}");
            Console.WriteLine($"Is Active: {issueDate}");
        }



    }
}
