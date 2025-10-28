using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    internal class CurrentAccount:BankAccount
    {
        private double overdraftLimit;
        private double transactionFee;

        public double OverdraftLimit
        { 
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public double TransactionFee
        {
            get { return transactionFee; }
            set { transactionFee = value; }
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Over Draft Limit: " + overdraftLimit);
            Console.WriteLine("Tramsaction Fee: " + transactionFee);
        }

        public bool CanWithdraw(double amount)
        {
            if (amount <= balance + overdraftLimit)
                return true;
            else
                return false;
        }

        public bool CanWithdraw(double amount, double fee)
        {
            if(amount <= (balance - fee + overdraftLimit))
                return true; 
            else
                return false;
        }

        public CurrentAccount()
        {

        }

        public CurrentAccount(int accountNumber, string holderName, double balance, double overdraftLimit, double transactionFee):base(accountNumber, holderName, balance)
        {
            this.overdraftLimit = overdraftLimit;
            this.transactionFee = transactionFee;
        }

    }
}
