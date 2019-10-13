using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    [Scope(Feature = "FullEnrollmentNumberGenerator")]
    public class FullEnrollmentNumberGeneratorSteps
    {
        private string _result;
        private Exception _exception = null;

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
        
        [When(@"I input (.*) into the FullEnrollmentNumberGenerator")]
        public void WhenIInputIntoTheFullEnrollmentNumberGenerator(string enrollmentNumber)
        {
            var generator = new FullEnrollmentNumberGenerator(_checkDigitCalculator, _hexadecimalConverter);

            try
            {
                _result = generator.Generate(enrollmentNumber);
            }
            catch (Exception e)
            {
                _exception = e;
            }
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string fullEnrollmentNumber)
        {
            Assert.AreEqual(fullEnrollmentNumber, _result);
        }
    }
}
