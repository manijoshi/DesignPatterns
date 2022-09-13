using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmiPro created...");
        }
    }
}
