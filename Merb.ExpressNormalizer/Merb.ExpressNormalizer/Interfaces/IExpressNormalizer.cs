namespace Merb.XsdExpressNormalizer.Interfaces
{
    public interface IExpressNormalizer
    {
        INormalizerResult Normalize(INormalizerInput input);
    }
}