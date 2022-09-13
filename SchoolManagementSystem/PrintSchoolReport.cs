using ReportPrinter;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagementSystem
{
    public class PrintSchoolReport : Print
    {
        public void PrintReport()
        {
            PrintTemplate();
        }
        public override void PrintBody()
        {
            Console.WriteLine("This is to certify that Mr. John has been promoted to "+"5th standard");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("\t\t             School Report");
            Console.WriteLine("\t ------------------------------------------------ \n\n");

        }
    }
}
