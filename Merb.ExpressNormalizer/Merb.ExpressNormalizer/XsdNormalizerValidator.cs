using Merb.ExpressNormalizer.Interfaces;

namespace Merb.ExpressNormalizer
{
    public class XsdNormalizerValidator : INormalizerValidator
    {
        public INormalizerValidationResult Validate(INormalizerInput input)
        {
            if (input == null)
                return NormalizerValidationResult.NullResult;

            throw new System.NotImplementedException();
        }
    }
}
