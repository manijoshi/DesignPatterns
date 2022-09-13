using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Signal
{
    public class SamsungGalaxySignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung Galaxy's strength is good..");
        }
    }
}
