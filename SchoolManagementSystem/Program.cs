using System;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSchoolReport report = new PrintSchoolReport();
            report.PrintReport();
            Console.ReadKey();
        }
    }
}
