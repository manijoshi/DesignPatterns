using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.BusinessService
{
    public class DebitCardPayment : IPaymentProcessor
    {
        public bool Process(string bankDetail)
        {
            if (ProcessPaymentDebitCard())
            {
                return true;
            }
            return false;
        }
        private bool ProcessPaymentDebitCard()
        {
            return true;
        }
    }
}
