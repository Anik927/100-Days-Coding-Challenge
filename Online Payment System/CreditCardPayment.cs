using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{
    internal class CreditCardPayment:Payment
    {
        public override bool Validate()
        {
            Console.Write("Enter Your Card Number: ");
            string cardNum = Console.ReadLine();
            Console.Write("Enter Your Card CVV: ");
            string cardCVV = Console.ReadLine();

            return cardNum.Length == 16 && cardCVV.Length == 3;

        }

        public override bool ProcessPayment(double amount)
        {
            return amount>=0 && transactionId>0;
        }

    }
}
