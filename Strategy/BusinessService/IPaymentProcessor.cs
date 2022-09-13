using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.BusinessService
{
    public interface IPaymentProcessor
    {
        bool Process(string bankDetail);
    }
}
