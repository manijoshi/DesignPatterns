using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Mobile
{
    class XiaomiRedmi6:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi6 created...");
        }
    }
}
