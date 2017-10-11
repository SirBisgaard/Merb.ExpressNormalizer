using Merb.XsdExpressNormalizer.Interfaces;

namespace Merb.XsdExpressNormalizer
{
    public struct XsdNormalizerResult : INormalizerResult
    {
        public static readonly INormalizerResult NullResult = new XsdNormalizerResult();
    }
}
