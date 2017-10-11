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
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(NormalizerValidationResult.NotValid, result);
        }

        [TestMethod]
        public void ValidationResult_ShouldNotBeValid_WhenInputNameIsNullOrEmpty()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;

            Assert.IsFalse(
                sut.Validate(new XsdNormalizerInput(
                    null,
                    "Content")).IsValid);
            Assert.IsFalse(
                sut.Validate(new XsdNormalizerInput(
                    string.Empty, 
                    "Content")).IsValid);
        }

        [TestMethod]
        public void ValidationResult_ShouldNotBeValid_WhenInputContentIsNullOrEmpty()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;

            Assert.IsFalse(
                sut.Validate(new XsdNormalizerInput(
                    "Name",
                    null)).IsValid);
            Assert.IsFalse(
                sut.Validate(new XsdNormalizerInput(
                    "Name",
                    string.Empty)).IsValid);
        }
    }
}
