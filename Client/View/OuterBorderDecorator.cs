using System;
using System.Collections.Generic;
using System.Text;

namespace Client.View
{
    class OuterBorderDecorator:DesignerDecoratorBase
    {
        public OuterBorderDecorator(IDesigner designer):base(designer){}
        public override string GetTableStyle()
        {
            string html = "<table border=15 bordercolor=#9A333D>";
            html += "<tr>";
            html += $"<th>{base.GetTableStyle()}</th>";
            html += "</tr>";
            html += "</table>";
            return html;

        }
    }
}
