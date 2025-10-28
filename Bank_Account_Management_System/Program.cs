using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba1 = new BankAccount();
            BankAccount ba2 = new BankAccount(1,"Anik",100.65);
            ba2.ShowDetails();           

            SavingsAccount sa1 = new SavingsAccount();
            SavingsAccount sa2 = new SavingsAccount(2,"Kaif",134.98,2,80);
            sa2.ShowDetails();
            sa2.CalculateAnnualInterest();
            sa2.IsPenaltyApplicable();

            CurrentAccount ca1 = new CurrentAccount();
            CurrentAccount ca2 = new CurrentAccount(3,"Nuha",789.98,200.87,23.44);
            ca2.ShowDetails();
            Console.WriteLine(ca2.CanWithdraw(300));
            Console.WriteLine(ca2.CanWithdraw(300, 600));

            Console.WriteLine("Total Account: " + BankAccount.TotalAccount);

        }
    }
}
