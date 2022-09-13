using Decorator.CostCalculators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CostCalculators
{
    public class CostCalculator : ICostCalculator
    {
        public double GetTotalCost(List<OrderDto> orders)
        {
            double total = 0;
            foreach(OrderDto order in orders)
            {
                total += (order.Quantity * order.Price);
            }
            return total;
        }
    }
}
