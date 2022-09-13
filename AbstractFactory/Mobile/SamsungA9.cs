using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Mobile
{
    public class SamsungA9:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung A9 created...");
        }
    }
}
