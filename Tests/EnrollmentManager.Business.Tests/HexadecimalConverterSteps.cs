using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    public class HexadecimalConverterSteps
    {
        private string _result;

        [When(@"I input the value (.*)")]
        public void WhenIInputTheValue(int decimalInt)
        {
            var converter = new HexadecimalConverter();
            _result = converter.ConvertToHexadecimal(decimalInt);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string hexadecimal)
        {
            Assert.AreEqual(hexadecimal, _result);
        }
    }
}
