using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SalesApplication
{
    public interface ISales
    {
        void ShowSalesData(XmlNode xmlSalesData);
    }
}
