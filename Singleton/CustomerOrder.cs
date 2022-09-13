using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class CustomerOrder
    {
        private readonly ILogger _logger;
        public CustomerOrder(ILogger logger)
        {
            _logger = logger;
        }
        public void PlaceOrder(int orderNumber)
        {
            _logger.LogInfo($"Order number {orderNumber} is processed successfully!!");
        }
    }
}
