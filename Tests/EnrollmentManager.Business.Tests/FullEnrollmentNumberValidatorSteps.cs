using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    [Scope(Feature = "FullEnrollmentNumberValidator")]
    public class FullEnrollmentNumberValidatorSteps
    {
        private bool _result;

        private ICheckDigitCalculator _checkDigitCalculator;
        private IHexadecimalConverter _hexadecimalConverter;

        [Given(@"the CheckDigitCalculator returns (.*) for the input (.*)")]
        public void GivenTheCheckDigitCalculatorReturnsForTheInput(int decimalCheckDigit, string enrollmentNumber)
        {
            var mqCheckDigitCalculator = new Mock<ICheckDigitCalculator>(MockBehavior.Strict);
            mqCheckDigitCalculator
                .Setup(c => c.Calculate(enrollmentNumber))
                .Returns(decimalCheckDigit);

            _checkDigitCalculator = mqCheckDigitCalculator.Object;
        }
        
        [Given(@"the HexadecimalConverter returns (.*) for the input (.*)")]
        public void GivenTheHexadecimalConverterReturnsForTheInput(string checkDigit, int decimalCheckDigit)
        {
            var mqHexadecimalConverter = new Mock<IHexadecimalConverter>(MockBehavior.Strict);
            mqHexadecimalConverter
                .Setup(c => c.ConvertToHexadecimal(decimalCheckDigit))
                .Returns(checkDigit);

            _hexadecimalConverter = mqHexadecimalConverter.Object;
        }

        [Given(@"the CheckDigitCalculator throws a FormatException")]
        public void GivenTheCheckDigitCalculatorThrowsAFormatException()
        {
            var mqCheckDigitCalculator = new Mock<ICheckDigitCalculator>(MockBehavior.Strict);
            mqCheckDigitCalculator
                .Setup(c => c.Calculate(It.IsAny<string>()))
                .Throws<FormatException>();

            _checkDigitCalculator = mqCheckDigitCalculator.Object;
            _hexadecimalConverter = Mock.Of<IHexadecimalConverter>(MockBehavior.Loose);
        }
        
        [Given(@"the HexadecimalConverter throws an ArgumentOutOfRangeException")]
        public void GivenTheHexadecimalConverterThrowsAnArgumentOutOfRangeException()
        {
            var mqHexadecimalConverter = new Mock<IHexadecimalConverter>(MockBehavior.Strict);
            mqHexadecimalConverter
                .Setup(c => c.ConvertToHexadecimal(It.IsAny<int>()))
                .Throws<ArgumentOutOfRangeException>();

            _hexadecimalConverter = mqHexadecimalConverter.Object;
            _checkDigitCalculator = Mock.Of<ICheckDigitCalculator>(MockBehavior.Loose);
        }
        
        [When(@"I input (.*) into the FullEnrollmentNumberValidator")]
        public void WhenIInputIntoTheFullEnrollmentNumberValidator(string fullEnrollmentNumber)
        {
            var validator = new FullEnrollmentNumberValidator(_checkDigitCalculator, _hexadecimalConverter);
            _result = validator.Validate(fullEnrollmentNumber);
        }
        
        [When(@"I call the Validate Method")]
        public void WhenICallTheValidateMethod()
        {
            var validator = new FullEnrollmentNumberValidator(_checkDigitCalculator, _hexadecimalConverter);
            _result = validator.Validate(It.IsAny<string>());
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(bool result)
        {
            Assert.AreEqual(result, _result);
        }
    }
}
