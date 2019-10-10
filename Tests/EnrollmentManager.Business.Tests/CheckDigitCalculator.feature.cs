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
    [TechTalk.SpecRun.FeatureAttribute("CheckDigitCalculator", Description="\tChecking the check digit calculataion of enrollments, in its decimal representat" +
        "ion", SourceFile="CheckDigitCalculator.feature", SourceLine=0)]
    public partial class CheckDigitCalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CheckDigitCalculator.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CheckDigitCalculator", "\tChecking the check digit calculataion of enrollments, in its decimal representat" +
                    "ion", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void EnrollmentNumberBetween0000And9999(string enrollmentNumber, string checkDigit, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enrollment number between 0000 and 9999", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.When(string.Format("I input the enrollment {0}", enrollmentNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("the check digit should be {0}", checkDigit), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 0000", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_0000()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("0000", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 0001", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_0001()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("0001", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 0010", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_0010()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("0010", "3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 0100", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_0100()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("0100", "4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1000", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1000()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1000", "5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 0954", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_0954()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("0954", "14", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1334", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1334()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1334", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1392", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1392()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1392", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1486", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1486()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1486", "12", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1548", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1548()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1548", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 1717", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_1717()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("1717", "12", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 2881", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_2881()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("2881", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 2931", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_2931()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("2931", "5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 8972", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_8972()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("8972", "6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Enrollment number between 0000 and 9999, 9105", SourceLine=9)]
        public virtual void EnrollmentNumberBetween0000And9999_9105()
        {
#line 4
this.EnrollmentNumberBetween0000And9999("9105", "11", ((string[])(null)));
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
