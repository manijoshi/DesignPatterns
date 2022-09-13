using FactoryMethod.FactoryInterface;
using FactoryMethod.Product;
using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory
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
    }
}
