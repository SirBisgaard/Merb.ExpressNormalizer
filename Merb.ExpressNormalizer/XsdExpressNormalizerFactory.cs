using System;

namespace Merb.ExpressNormalizer
{
    public class XsdExpressNormalizerFactory
    {
        public IExpressNormalizer CreateInstance() => new XsdExpressNormalizer();
    }
}
