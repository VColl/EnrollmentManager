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
    [TechTalk.SpecRun.FeatureAttribute("HexadecimalConverter", Description="\tChecking the convertion of an integer from decimal representation to hexadecimal" +
        " representation", SourceFile="HexadecimalConverter.feature", SourceLine=0)]
    public partial class HexadecimalConverterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HexadecimalConverter.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HexadecimalConverter", "\tChecking the convertion of an integer from decimal representation to hexadecimal" +
                    " representation", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ConvertingTheRange0_15(string @decimal, string hexadecimal, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Converting the range 0-15", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.When(string.Format("I input the value {0}", @decimal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("the result should be \"{0}\"", hexadecimal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 00", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_00()
        {
#line 4
this.ConvertingTheRange0_15("00", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 01", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_01()
        {
#line 4
this.ConvertingTheRange0_15("01", "1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 02", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_02()
        {
#line 4
this.ConvertingTheRange0_15("02", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 03", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_03()
        {
#line 4
this.ConvertingTheRange0_15("03", "3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 04", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_04()
        {
#line 4
this.ConvertingTheRange0_15("04", "4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 05", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_05()
        {
#line 4
this.ConvertingTheRange0_15("05", "5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 06", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_06()
        {
#line 4
this.ConvertingTheRange0_15("06", "6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 07", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_07()
        {
#line 4
this.ConvertingTheRange0_15("07", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 08", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_08()
        {
#line 4
this.ConvertingTheRange0_15("08", "8", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 09", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_09()
        {
#line 4
this.ConvertingTheRange0_15("09", "9", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 10", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_10()
        {
#line 4
this.ConvertingTheRange0_15("10", "A", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 11", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_11()
        {
#line 4
this.ConvertingTheRange0_15("11", "B", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 12", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_12()
        {
#line 4
this.ConvertingTheRange0_15("12", "C", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 13", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_13()
        {
#line 4
this.ConvertingTheRange0_15("13", "D", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 14", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_14()
        {
#line 4
this.ConvertingTheRange0_15("14", "E", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Converting the range 0-15, 15", SourceLine=9)]
        public virtual void ConvertingTheRange0_15_15()
        {
#line 4
this.ConvertingTheRange0_15("15", "F", ((string[])(null)));
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
