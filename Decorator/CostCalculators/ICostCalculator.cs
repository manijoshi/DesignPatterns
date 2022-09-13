using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.CostCalculators
{
    public interface ICostCalculator
    {
        double GetTotalCost(List<OrderDto> orders);
    }
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    public class ShoppingCartDto
    {
        public List<OrderDto> Orders { get; set; }
        public double TotalPrice { get; set; }
    }
}
