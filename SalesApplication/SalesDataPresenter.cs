using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SalesApplication
{
    public class SalesDataPresenter : ISales
    {
        public void ShowSalesData(XmlNode xmlSalesData)
        {
            Console.WriteLine(xmlSalesData.InnerXml);
        }
    }
}
