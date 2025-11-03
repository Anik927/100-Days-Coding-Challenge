using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{
    internal abstract class Payment : IPayable
    {
        protected double amount;
        protected int transactionId;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        public Payment() { }

        public Payment(double amount, int transactionId)
        {
            this.amount = amount;
            this.transactionId = transactionId;
        }

        public abstract bool ProcessPayment(double amount);

        public abstract bool Validate();

    }
}
