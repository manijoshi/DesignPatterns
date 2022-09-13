using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
    }
}
