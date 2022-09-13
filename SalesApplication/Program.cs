using System;

namespace SalesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager manager = new SalesManager();
            manager.Process();
            Console.ReadKey();
        }
    }
}
