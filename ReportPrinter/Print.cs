using System;
using System.Collections.Generic;
using System.Text;

namespace ReportPrinter
{
    public abstract class Print
    {
        public abstract void PrintHeader();
        public abstract void PrintBody();
        public void PrintTemplate()
        {
            PrintLogo();
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        private void PrintLogo()
        {
            Console.WriteLine("\n\t\t\tRAIGENICS LOGO !\n");
        }
        private void PrintFooter()
        {
            Console.WriteLine("\n\t ---------------------------------------------------------- \n\n");
            Console.WriteLine("\t\t RAIGENICS FOOTER CONTENT !");
        }
    }
}
