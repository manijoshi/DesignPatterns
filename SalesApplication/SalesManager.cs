using GraphReport;
using SalesDataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    public class SalesManager
    {
        public void Process()
        {
            var salesData = new SalesDataReader().GetSalesData();
            ISales sales = new SalesDataPresenterAdapter(new DisplayGraph());
            sales.ShowSalesData(salesData);
        }
    }
}
