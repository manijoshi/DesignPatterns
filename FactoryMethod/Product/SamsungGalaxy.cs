using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    class SamsungGalaxy:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung Galaxy created...");
        }
    }
}
