using Merb.XsdExpressNormalizer.Interfaces;

namespace Merb.XsdExpressNormalizer
{
    public class XsdExpressNormalizer : IExpressNormalizer
    {
        public INormalizerResult Normalize(INormalizerInput input)
        {
            if (input == null)
                return XsdNormalizerResult.NullResult;

            throw new System.NotImplementedException();
        }
    }

    public struct XsdNormalizerResult : INormalizerResult
    {
        public static readonly INormalizerResult NullResult = new XsdNormalizerResult();
    }
}
