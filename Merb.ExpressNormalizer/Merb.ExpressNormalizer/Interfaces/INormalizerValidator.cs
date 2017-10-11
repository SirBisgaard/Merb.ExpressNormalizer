namespace Merb.ExpressNormalizer.Interfaces
{
    public interface INormalizerValidator
    {
        INormalizerValidationResult Validate(INormalizerInput input);
    }
}