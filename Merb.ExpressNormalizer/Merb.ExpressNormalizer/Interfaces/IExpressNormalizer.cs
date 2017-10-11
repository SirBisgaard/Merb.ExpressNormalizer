namespace Merb.ExpressNormalizer.Interfaces
{
    public interface IExpressNormalizer
    {
        INormalizerResult Normalize(INormalizerInput input);
    }
}