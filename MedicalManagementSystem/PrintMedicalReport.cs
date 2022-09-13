using ReportPrinter;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalManagementSystem
{
    public class PrintMedicalReport : Print
    {
        public void PrintReport()
        {
            PrintTemplate();
        }
        public override void PrintBody()
        {
            Console.WriteLine("This is to certify that Mr. John was examined by the undersigned"+"\nand was found out to be in good health and is physically and mentally fit to perform classroom activities. ");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("\t\t             Medical Report");
            Console.WriteLine("\t ------------------------------------------------ \n\n");

        }
    }
}
