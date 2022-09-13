
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
    public class SamsungFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxy();
                case ModelType.A9:
                    return new SamsungA9();
                default:
                    throw new Exception("Invalid model type...");
            }
        }

        public ISignal GetSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxySignal();
                default:
                    throw new Exception("Invalid mobile type...");
            }
        }
    }
}
