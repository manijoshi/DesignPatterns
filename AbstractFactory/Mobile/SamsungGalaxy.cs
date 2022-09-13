using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Mobile
{
    class SamsungGalaxy:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung Galaxy created...");
        }
    }
}
