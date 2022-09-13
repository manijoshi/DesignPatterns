using GraphReport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SalesApplication
{
    public class SalesDataPresenterAdapter : ISales
    {
        private readonly IGraph _graph;

        public SalesDataPresenterAdapter(IGraph graph)
        {
            _graph = graph;
        }
        public void ShowSalesData(XmlNode xmlSalesData)
        {
            var jSon = JsonConvert.SerializeXmlNode(xmlSalesData,Newtonsoft.Json.Formatting.Indented);
            _graph.ShowGraph(jSon);
        }
    }
}
