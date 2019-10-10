using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    public class CheckDigitCalculatorSteps
    {
        private int _result;

        [When(@"I input the enrollment (.*)")]
        public void WhenIInputTheEnrollment(int enrollmentNumber)
        {
            var calculator = new CheckDigitCalculator();
            _result = calculator.Calculate(enrollmentNumber);
        }
        
        [Then(@"the check digit should be (.*)")]
        public void ThenTheCheckDigitShouldBe(int checkDigit)
        {
            Assert.AreEqual(checkDigit, _result);
        }
    }
}
