using Merb.ExpressNormalizer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Merb.XsdExpressNormalizer.Tests
{
    [TestClass]
    public class XsdExpressNormalizerTests
    {
        private struct TestDommyNormalizerInput : INormalizerInput
        {
            public string Name => throw new NotImplementedException();

            public string Content => throw new NotImplementedException();
        }

        [TestMethod]
        public void NormalizedResult_ShouldNotBeNull_WhenNormalizeIsGivenNull()
        {
            var sut = new XsdExpressNormalizer() as IExpressNormalizer;
            var result = sut.Normalize(null);

            Assert.IsNotNull(result);
            Assert.AreEqual(XsdNormalizerResult.NullResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NormalizedInput_ShouldAllwasThrowException_WhenWrongInputTypeIsGiven()
        {
            var sut = new XsdExpressNormalizer() as IExpressNormalizer;
            var result = sut.Normalize(new TestDommyNormalizerInput());
        }
    }
}
