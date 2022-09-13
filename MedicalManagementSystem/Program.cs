using System;

namespace MedicalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMedicalReport report = new PrintMedicalReport();
            report.PrintReport();
            Console.ReadKey();
        }
    }
}
