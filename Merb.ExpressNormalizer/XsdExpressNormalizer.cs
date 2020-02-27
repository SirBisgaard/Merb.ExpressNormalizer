using System;

namespace Merb.ExpressNormalizer
{
    public class XsdExpressNormalizer : IExpressNormalizer
    {
        public INormalizerValidator Validator { get; set; } = new XsdNormalizerValidator();

        public INormalizerResult Normalize(INormalizerInput input)
        {
            if (input == null)
                return XsdNormalizerResult.NullResult;
            if (input.GetType() != typeof(XsdNormalizerInput))
                throw new ArgumentException($"The {nameof(XsdExpressNormalizer)} can only handle {nameof(XsdNormalizerInput)} as input.", nameof(input));

            throw new NotImplementedException();
        }
    }
}
