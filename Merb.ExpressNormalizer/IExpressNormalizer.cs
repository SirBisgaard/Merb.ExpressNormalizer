using System;

namespace Merb.ExpressNormalizer
{
    public interface IExpressNormalizer
    {
        INormalizerValidator Validator { get; set; }

        INormalizerResult Normalize(INormalizerInput input);
    }
}
