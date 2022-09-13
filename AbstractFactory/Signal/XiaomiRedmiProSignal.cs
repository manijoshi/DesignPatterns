using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Signal
{
    public class XiaomiRedmiProSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Xiaomi Redmi Pro signal strength is poor. Consider changing mobile network.");
        }
    }
}
