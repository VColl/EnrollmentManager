using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace EnrollmentManager.Business.Tests
{
    [Binding]
    [Scope(Feature = "HexadecimalConverter")]
    public class HexadecimalConverterSteps
    {
        private string _result;
        private Exception _exception = null;

        [When(@"I input the value (.*)")]
        public void WhenIInputTheValue(int decimalInt)
        {
            var converter = new HexadecimalConverter();

            try
            {
                _result = converter.ConvertToHexadecimal(decimalInt);
            }
            catch (Exception e)
            {
                _exception = e;
            }
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string hexadecimal)
        {
            Assert.AreEqual(hexadecimal, _result);
        }

        [Then(@"An ArgumentOutOfRangeException should be thrown")]
        public void ThenAnArgumentOutOfRangeExceptionShouldBeThrown()
        {
            Assert.IsInstanceOfType(_exception, typeof(ArgumentOutOfRangeException));
        }

    }
}
