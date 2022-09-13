
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class CreditCardPaymentHandler:Handler
    {
        public override void Handle(Product product)
        {
            var creditCardSystem = new CreditCardPaymentSystem();
            if (creditCardSystem.CanPayCreditCard(product.Cost))
            {
                creditCardSystem.PayFromCreditCard(product.Cost);
                product.HandledBy = "Handled By Credit Card Payment Handler !";
                return;
            }
            product.HandledBy = "Not able to handle the request !";
        }
    }
}
