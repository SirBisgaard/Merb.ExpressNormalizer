namespace Merb.ExpressNormalizer
{
    public interface INormalizerValidator
    {
        INormalizerValidationResult Validate(INormalizerInput input);
    }
}
