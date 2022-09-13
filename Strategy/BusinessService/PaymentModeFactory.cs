using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.BusinessService
{
    public class PaymentModeFactory
    {
        public IPaymentProcessor CreateStrategy(string mode)
        {
            if (mode == "CreditCard")
            {
                return new CreditCardPayment();
            }
            return new DebitCardPayment();
        }
    }
}
