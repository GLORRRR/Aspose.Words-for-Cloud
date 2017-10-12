﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Aspose.Words.Cloud.Sdk.BddTests.Features.MailMerge.ExecuteTemplate.PutExecute
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class PutExecuteTemplateExecuteTemplateWithoutSavingFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PutExecuteTemplate.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PutExecuteTemplate execute template without saving", "In order to create personalized documents a user\r\nshould be able to perform mail " +
                    "merge", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "PutExecuteTemplate execute template without saving")))
            {
                Aspose.Words.Cloud.Sdk.BddTests.Features.MailMerge.ExecuteTemplate.PutExecute.PutExecuteTemplateExecuteTemplateWithoutSavingFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ExecuteTemplate(string templateName, string body, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutExecuteTemplate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Template", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have specified a template file {0} with mustache syntax", templateName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have specified a body file {0}", body), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I execute template online", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("document with merged values should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Template")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PutExecuteTemplate execute template without saving")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutExecuteTemplate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TestExecuteTemplate.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TemplateName", "TestExecuteTemplate.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Body", "TestExecuteTemplateData.txt")]
        public virtual void ExecuteTemplate_TestExecuteTemplate_Doc()
        {
            this.ExecuteTemplate("TestExecuteTemplate.doc", "TestExecuteTemplateData.txt", ((string[])(null)));
        }
        
        public virtual void ExecuteTemplateWithImages(string templateName, string body, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutExecuteTemplate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Template With Images", @__tags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given(string.Format("I have specified a template file {0} with mustache syntax", templateName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And(string.Format("I have specified a body file {0}", body), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I execute template online", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("document with merged values should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("image should be rendered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Template With Images")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PutExecuteTemplate execute template without saving")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutExecuteTemplate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "TestExecuteTemplateWithImages.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TemplateName", "TestExecuteTemplateWithImages.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Body", "TestDataWithRemoteScaledImages.xml")]
        public virtual void ExecuteTemplateWithImages_TestExecuteTemplateWithImages_Doc()
        {
            this.ExecuteTemplateWithImages("TestExecuteTemplateWithImages.doc", "TestDataWithRemoteScaledImages.xml", ((string[])(null)));
        }
        
        public virtual void ExecuteTemplateWithCleanupOptions(string templateName, string body, string cleanup, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutExecuteTemplate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Template With Cleanup Options", @__tags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given(string.Format("I have specified a template file {0} with mustache syntax", templateName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And(string.Format("I have specified a body file {0}", body), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And(string.Format("I have specified a cleanup option {0}", cleanup), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I execute template online", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("document with merged values should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("unused option is cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Template With Cleanup Options")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PutExecuteTemplate execute template without saving")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutExecuteTemplate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TemplateName", "TestMailMergeWithCleanupOptions.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Body", "TestCleanupOptionsData.xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Cleanup", "UnusedRegions")]
        public virtual void ExecuteTemplateWithCleanupOptions_Variant0()
        {
            this.ExecuteTemplateWithCleanupOptions("TestMailMergeWithCleanupOptions.doc", "TestCleanupOptionsData.xml", "UnusedRegions", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Template With Cleanup Options")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PutExecuteTemplate execute template without saving")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutExecuteTemplate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TemplateName", "TestMailMergeWithCleanupOptions.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Body", "TestCleanupOptionsData.xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Cleanup", "UnusedFields")]
        public virtual void ExecuteTemplateWithCleanupOptions_Variant1()
        {
            this.ExecuteTemplateWithCleanupOptions("TestMailMergeWithCleanupOptions.doc", "TestCleanupOptionsData.xml", "UnusedFields", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Template With Cleanup Options")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PutExecuteTemplate execute template without saving")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutExecuteTemplate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TemplateName", "TestMailMergeWithCleanupOptions.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Body", "TestCleanupOptionsData.xml")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Cleanup", "EmptyParagraphs")]
        public virtual void ExecuteTemplateWithCleanupOptions_Variant2()
        {
            this.ExecuteTemplateWithCleanupOptions("TestMailMergeWithCleanupOptions.doc", "TestCleanupOptionsData.xml", "EmptyParagraphs", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion