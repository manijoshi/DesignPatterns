using Client.View;
using DecoExample;
using Decorator;
using Decorator.CostCalculators;
using System;
using System.ComponentModel.Design;
using System.IO;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            View.IDesigner designer = new OuterBorderDecorator(new Designer());
            File.WriteAllText(@"C:\Users\manishajoshi\OneDrive - Nagarro\Desktop\ShoppingCart.htm", designer.GetTableStyle());

            //var cartDetails = new ShoppingCart("IN").GetShoppingCartDetail();
            //DisplayReport(cartDetails);
            Console.WriteLine("HTML table has been successfully created!!!");
            var op = new MessageConveyor().GetMessage();
            Console.WriteLine(op);
            Console.ReadKey();
        }
        private static void DisplayReport(ShoppingCartDto dto)
        {
            var itemOrdered = dto.Orders;
            for(int i = 0; i < itemOrdered.Count; i++)
            {
                Console.WriteLine($"Order Id: {itemOrdered[i].OrderId} " +
                    $"Price: {itemOrdered[i].Price} " +
                    $"Quantity: {itemOrdered[i].Quantity}");
            }
            Console.WriteLine($"Total Price: {dto.TotalPrice}");
        }
    }
}
