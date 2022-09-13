using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class DebitCardPaymentHandler:Handler
    {
        public override void Handle(Product product)
        {
            var debitCardSystem = new DebitCardPaymentSystem();
            if (debitCardSystem.CanPayDebitCard(product.Cost))
            {
                debitCardSystem.PayFromDebitCard(product.Cost);
                product.HandledBy = "Handled By Debit Card Payment Handler !";
                return;
            }
            product.HandledBy = "Not able to handle the request !";
        }
    }
}
