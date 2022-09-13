using Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.View
{
    public class Designer : IDesigner
    {
        public string GetTableStyle()
        {
            ShoppingCart _shoppingCart = new ShoppingCart("IN");
            var data = _shoppingCart.GetShoppingCartDetail();
            string html = "<table width = 500 height = 350 border=15 bordercolor=#044534";
            html += "<tr>";
            html += "<td colspan=3 align=center style='color:red'><h2>SHOPPING CART REPORT</h2></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<th style='padding:5'>ORDER ID</th><th style='padding:5'>PRICE</th><th style='padding:5'>QUANTITY</th>";
            html += "</tr>";
            foreach(var item in data.Orders)
            {
                html += "<tr>";
                html += $"<th style='padding:5'>{item.OrderId}</th><th style='padding:5'>{item.Price}</th><th style='padding:5'>{item.Quantity}</th>";
                html += "</tr>";
            }
            html += "<tr>";
            html += $"<th></th><th></th><th>TOTAL COST: {data.TotalPrice.ToString()}</th>";
            html += "</tr>";
            html += "</table>";
            return html;
        }
    }
}
