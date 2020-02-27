using System;
using Xunit;

namespace Merb.ExpressNormalizer.Test
{
    public class XsdExpressNormalizerTests
    {
         private struct TestDommyNormalizerInput : INormalizerInput
        {
            public string Name => throw new NotImplementedException();

            public string Content => throw new NotImplementedException();
        }

        [Fact]
        public void NormalizedResult_ShouldNotBeNull_WhenNormalizeIsGivenNull()
        {
            var sut = new XsdExpressNormalizer() as IExpressNormalizer;
            var result = sut.Normalize(null);

            Assert.NotNull(result);
            Assert.Equal(XsdNormalizerResult.NullResult, result);
        }


        [Fact]
        public void NormalizedInput_ShouldAllwasThrowException_WhenWrongInputTypeIsGiven()
        {
            var sut = new XsdExpressNormalizer() as IExpressNormalizer;
            Assert.Throws<ArgumentException>(() => sut.Normalize(new TestDommyNormalizerInput())); 
        }
    }
}
