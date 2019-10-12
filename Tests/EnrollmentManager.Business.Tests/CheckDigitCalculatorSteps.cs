using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    public class CheckDigitCalculatorSteps
    {
        private int _result = -1;
        private Exception _exception = null;

        [When(@"I input the enrollment (.*)")]
        public void WhenIInputTheEnrollment(string enrollmentNumber)
        {
            var calculator = new CheckDigitCalculator();

            try
            {
                _result = calculator.Calculate(enrollmentNumber);
            }
            catch (FormatException e)
            {
                _exception = e;
            }
        }

        [Then(@"the check digit should be (.*)")]
        public void ThenTheCheckDigitShouldBe(int checkDigit)
        {
            Assert.AreEqual(checkDigit, _result);
        }

        [Then(@"the method should throw a FormatException")]
        public void ThenTheMethodShouldThrowAFormatException()
        {
            Assert.IsInstanceOfType(_exception, typeof(FormatException));
        }
    }
}
