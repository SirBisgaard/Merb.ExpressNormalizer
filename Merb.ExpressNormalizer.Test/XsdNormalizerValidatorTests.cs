
using Xunit;

namespace Merb.ExpressNormalizer.Test
{
    public class XsdNormalizerValidatorTests
    {
        [Fact]
        public void ValidationResult_ShouldNotBeNull_WhenValidateIsGivenNull()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;
            var result = sut.Validate(null);

            Assert.NotNull(result);
            Assert.False(result.IsValid);
            Assert.Equal(NormalizerValidationResult.NotValid, result);
        }

        [Fact]
        public void ValidationResult_ShouldNotBeValid_WhenInputNameIsNullOrEmpty()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;

            Assert.False(
                sut.Validate(new XsdNormalizerInput(
                    null,
                    "Content")).IsValid);
            Assert.False(
                sut.Validate(new XsdNormalizerInput(
                    string.Empty, 
                    "Content")).IsValid);
        }

        [Fact]
        public void ValidationResult_ShouldNotBeValid_WhenInputContentIsNullOrEmpty()
        {
            var sut = new XsdNormalizerValidator() as INormalizerValidator;

            Assert.False(
                sut.Validate(new XsdNormalizerInput(
                    "Name",
                    null)).IsValid);
            Assert.False(
                sut.Validate(new XsdNormalizerInput(
                    "Name",
                    string.Empty)).IsValid);
        }
    }
}