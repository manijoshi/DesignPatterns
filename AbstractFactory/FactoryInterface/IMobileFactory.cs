using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
        ISignal GetSignalStrength(ModelType modelType);
    }
}
