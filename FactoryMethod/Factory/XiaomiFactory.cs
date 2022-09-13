using FactoryMethod.FactoryInterface;
using FactoryMethod.Product;
using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
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
    }
}
