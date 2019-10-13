// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EnrollmentManager.Business.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("FullEnrollmentNumberGenerator", Description="\tChecking the full enrollment number generation assuming that\r\n\tthe CheckDigitCal" +
        "culator and the HexadecimalConverter have\r\n\tthe correct behavior", SourceFile="FullEnrollmentNumberGenerator.feature", SourceLine=0)]
    public partial class FullEnrollmentNumberGeneratorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FullEnrollmentNumberGenerator.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FullEnrollmentNumberGenerator", "\tChecking the full enrollment number generation assuming that\r\n\tthe CheckDigitCal" +
                    "culator and the HexadecimalConverter have\r\n\tthe correct behavior", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void InputingAValidEnrollmentNumber(string enrollmentNumber, string decimalCheckDigit, string checkDigit, string fullEnrollmentNumber, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Inputing a valid enrollment number", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("the CheckDigitCalculator returns {0} for the input {1}", decimalCheckDigit, enrollmentNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("the HexadecimalConverter returns {0} for the input {1}", checkDigit, decimalCheckDigit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When(string.Format("I input {0} into the FullEnrollmentNumberGenerator", enrollmentNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("the result should be {0}", fullEnrollmentNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 0000", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_0000()
        {
#line 6
this.InputingAValidEnrollmentNumber("0000", "0", "0", "0000-0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 001", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_001()
        {
#line 6
this.InputingAValidEnrollmentNumber("001", "2", "2", "0001-2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 0010", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_0010()
        {
#line 6
this.InputingAValidEnrollmentNumber("0010", "3", "3", "0010-3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 100", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_100()
        {
#line 6
this.InputingAValidEnrollmentNumber("100", "4", "4", "0100-4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1000", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1000()
        {
#line 6
this.InputingAValidEnrollmentNumber("1000", "5", "5", "1000-5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 0954", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_0954()
        {
#line 6
this.InputingAValidEnrollmentNumber("0954", "11", "B", "0954-B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 954", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_954()
        {
#line 6
this.InputingAValidEnrollmentNumber("954", "11", "B", "0954-B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1334", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1334()
        {
#line 6
this.InputingAValidEnrollmentNumber("1334", "2", "2", "1334-2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1392", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1392()
        {
#line 6
this.InputingAValidEnrollmentNumber("1392", "0", "0", "1392-0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1486", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1486()
        {
#line 6
this.InputingAValidEnrollmentNumber("1486", "9", "9", "1486-9", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1548", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1548()
        {
#line 6
this.InputingAValidEnrollmentNumber("1548", "5", "5", "1548-5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 1717", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_1717()
        {
#line 6
this.InputingAValidEnrollmentNumber("1717", "2", "2", "1717-2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 2 881", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_2881()
        {
#line 6
this.InputingAValidEnrollmentNumber("2 881", "4", "4", "2881-4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 293 1", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_2931()
        {
#line 6
this.InputingAValidEnrollmentNumber("293 1", "9", "9", "2931-9", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 89 7  2", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_8972()
        {
#line 6
this.InputingAValidEnrollmentNumber("89 7  2", "5", "5", "8972-5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Inputing a valid enrollment number, 9105", SourceLine=13)]
        public virtual void InputingAValidEnrollmentNumber_9105()
        {
#line 6
this.InputingAValidEnrollmentNumber("9105", "11", "B", "9105-B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion