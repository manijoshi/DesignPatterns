using Decorator.CostCalculators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class SalesTaxDecorator : CostCalculatorBaseDecorator
    {
        private readonly double _taxRate;
        public SalesTaxDecorator(double taxRate,ICostCalculator costCalculator) : base(costCalculator)
        {
            _taxRate = taxRate;
        }
        public override double GetTotalCost(List<OrderDto> orders)
        {
            return base.GetTotalCost(orders)*_taxRate;
        }
    }
}
