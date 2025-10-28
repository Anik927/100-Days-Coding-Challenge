using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    internal class BankAccount
    {
        protected int accountNumber;
        protected string holderName;
        protected double balance;

        protected static int totalAccount;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        
        public string HolderName
        { get { return holderName; }
          set { holderName = value; } 
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public static int TotalAccount
        {
            get { return totalAccount; }
            set { totalAccount = value; }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: " + balance);          
        }

        public BankAccount()
        {
            totalAccount++;
        }

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
            totalAccount++;
        }
    }
}
