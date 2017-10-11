using Merb.ExpressNormalizer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Merb.ExpressNormalizer.Tests
{
    [TestClass]
    public class XsdNormalizerValidatorTests
    {
        [TestMethod]
        public void ValidationResult_ShouldNotBeNull_WhenValidateIsGivenNull()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;
            var result = sut.Validate(null);

            Assert.IsNotNull(result);
            Assert.AreEqual(NormalizerValidationResult.NullResult, result);
        }
    }
}
