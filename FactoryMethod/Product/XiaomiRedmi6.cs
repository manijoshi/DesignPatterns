using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    class XiaomiRedmi6:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi6 created...");
        }
    }
}
