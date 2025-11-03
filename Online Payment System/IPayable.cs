using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Payment_System
{
    internal interface IPayable
    {
        bool ProcessPayment(double amount);
    }
}
