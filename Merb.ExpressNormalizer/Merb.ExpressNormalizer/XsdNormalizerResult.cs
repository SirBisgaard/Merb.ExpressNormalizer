
using Merb.ExpressNormalizer.Interfaces;

namespace Merb.ExpressNormalizer
{
    public struct XsdNormalizerResult : INormalizerResult
    {
        public static readonly INormalizerResult NullResult = new XsdNormalizerResult();
    }
}
