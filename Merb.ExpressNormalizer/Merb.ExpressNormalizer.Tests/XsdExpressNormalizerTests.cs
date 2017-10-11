using Microsoft.VisualStudio.TestTools.UnitTesting;
using Merb.XsdExpressNormalizer.Interfaces;

namespace Merb.XsdExpressNormalizer.Tests
{
    [TestClass]
    public class XsdExpressNormalizerTests
    {
        [TestMethod]
        public void NormalizedResult_ShouldNotBeNull_WhenGivenNull()
        {
            var sut = new XsdExpressNormalizer() as IExpressNormalizer;
            var result = sut.Normalize(null);

            Assert.IsNotNull(result);
        }
    }
}
