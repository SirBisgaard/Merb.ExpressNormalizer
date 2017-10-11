using Merb.ExpressNormalizer.Interfaces;

namespace Merb.ExpressNormalizer
{
    public struct XsdNormalizerInput : INormalizerInput
    {
        public XsdNormalizerInput(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public string Name { get; }

        public string Content { get; }
    }
}
