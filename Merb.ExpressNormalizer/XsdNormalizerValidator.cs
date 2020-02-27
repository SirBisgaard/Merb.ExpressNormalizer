namespace Merb.ExpressNormalizer
{
    public class XsdNormalizerValidator : INormalizerValidator
    {
        public INormalizerValidationResult Validate(INormalizerInput input)
        {
            if (input == null)
                return NormalizerValidationResult.NotValid;
            if (string.IsNullOrEmpty(input.Name))
                return NormalizerValidationResult.NotValid;
            if (string.IsNullOrEmpty(input.Content))
                return NormalizerValidationResult.NotValid;

            throw new System.NotImplementedException();
        }
    }
}
