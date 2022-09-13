using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.BusinessService
{
    public class Context
    {
        private IPaymentProcessor _processor;
        public void SetPaymentStrategy(IPaymentProcessor processor)
        {
            _processor = processor;
        }
        public bool ProcessPayment(string bankDetail)
        {
            return _processor.Process(bankDetail);
        }
    }
}
