using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SalesDataAccessLibrary
{
    public class SalesDataReader
    {
        public XmlNode GetSalesData()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("SalesDatas");
            var xAttributes = new SqlDataAccess().GetSalesData().Select(x => new XElement("SalesData",
                new XAttribute("Name", x.Name), new XAttribute("Sales", x.Sales)));
            xElement.Add(xAttributes);
            XmlDocument xmlNode = new XmlDocument();
            using(XmlReader xmlReader = xElement.CreateReader())
            {
                xmlNode.Load(xmlReader);
            }
            return xmlNode;
        }
    }
}
