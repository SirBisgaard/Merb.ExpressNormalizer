namespace Merb.XsdExpressNormalizer
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
