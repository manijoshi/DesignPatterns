
using AbstractFactory;
using AbstractFactory.FactoryInterface;
using AbstractFactory.Mobile;
using AbstractFactory.ProductInterface;
using AbstractFactory.Signal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class XiaomiFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Redmi6:
                    return new XiaomiRedmi6();
                case ModelType.RedmiPro:
                    return new XiaomiRedmiPro();
                default:
                    throw new Exception("Invalid model type....");
            }
        }

        public ISignal GetSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.RedmiPro:
                    return new XiaomiRedmiProSignal();
                default:
                    throw new Exception("Invalid mobile type...");
            }
        }
    }
}
