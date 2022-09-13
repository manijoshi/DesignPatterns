using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDataAccessLibrary
{
    public class SalesDto
    {
        public string Name { get; set; }
        public int Sales { get; set; }
    }
    public class SqlDataAccess
    {
        public List<SalesDto> GetSalesData()
        {
            return new List<SalesDto>
            {
                new SalesDto{Name="John",Sales=200},
                new SalesDto{Name="Ravi",Sales=1000},
                new SalesDto{Name="Merry",Sales=300}
            };
        }
    }
}
