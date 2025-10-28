using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    internal class SavingsAccount:BankAccount
    {
        private double interestRate;
        private double minimumBalance;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double MinimumBalance
        { 
            get { return minimumBalance; }
            set { minimumBalance = value; }
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Interest Rate: " + interestRate);
            Console.WriteLine("Minimum Balance: " + minimumBalance);
        }

        public double CalculateAnnualInterest()
        { 
            return balance*interestRate; 
        }

        public bool IsPenaltyApplicable()
        {
            if (balance < minimumBalance)
                return true;
            else
                return false;
        }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int accountNumber, string holderName, double balance, double interestRate, double minimumBalance):base(accountNumber, holderName, balance)
        {
            this.interestRate = interestRate;
            this.minimumBalance = minimumBalance;
        }


    }
}