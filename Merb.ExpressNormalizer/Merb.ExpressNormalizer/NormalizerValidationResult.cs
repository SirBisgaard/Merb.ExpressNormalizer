using Merb.ExpressNormalizer.Interfaces;

namespace Merb.ExpressNormalizer
{
    public struct NormalizerValidationResult : INormalizerValidationResult
    {
        public static readonly INormalizerValidationResult NotValid = new NormalizerValidationResult(false);

        public NormalizerValidationResult(bool isValid)
        {
            IsValid = isValid;
        }

        public bool IsValid { get; }
    }
}
