using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.BusinessService
{
    public class CreditCardPayment : IPaymentProcessor
    {
        public bool Process(string bankDetail)
        {
            if (ProcessPaymentCreditCard())
            {
                return true;
            }
            return false;
        }
        private bool ProcessPaymentCreditCard()
        {
            return true;
        }
    }
}
