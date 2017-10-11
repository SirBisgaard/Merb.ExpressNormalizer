namespace Merb.ExpressNormalizer.Interfaces
{
    public interface IExpressNormalizer
    {
        INormalizerValidator Validator { get; set; }

        INormalizerResult Normalize(INormalizerInput input);
    }
}