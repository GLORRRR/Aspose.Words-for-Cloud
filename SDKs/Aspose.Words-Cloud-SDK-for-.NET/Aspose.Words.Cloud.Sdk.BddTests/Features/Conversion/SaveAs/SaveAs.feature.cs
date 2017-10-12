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
namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.SaveAs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StoredDocumentConversionWithSaveResultToStorageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SaveAs.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Stored document conversion with save result to storage", "In order to reuse document content for various purposes (such as read-only PDF di" +
                    "stribution)\r\nA user should be able to convert Word document to different formats" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Stored document conversion with save result to storage")))
            {
                Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.SaveAs.StoredDocumentConversionWithSaveResultToStorageFeature.FeatureSetup(null);
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
        
        public virtual void ConvertDocumentFormStorageAndSaveToStorage(string docName, string destFormat, string outPath, string loadEncoding, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "StoredDocConversionWithStorage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert document form storage and save to storage", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have uploaded document with name {0} to storage", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have specified save format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And(string.Format("I have specified document name {0} in URL", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("I have specified destFileName {0}", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("I have specified encoding {0}", loadEncoding), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("I execute conversion from storage (POST SaveAs)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then(string.Format("document {0} is existed on storage", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("document from storage is downloadble", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("symbols are encoded properly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/TableDocumentPdf.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant0()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("TableDocument.doc", "pdf", "out/saveus/TableDocumentPdf.pdf", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/test_docPdf.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant1()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("test_doc.docx", "pdf", "out/saveus/test_docPdf.pdf", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/test_docPng.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant2()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("test_doc.docx", "png", "out/saveus/test_docPng.pdf", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/test_docHtml.html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant3()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("test_doc.docx", "html", "out/saveus/test_docHtml.html", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/TableDocumentHtml.html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant4()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("TableDocument.doc", "html", "out/saveus/TableDocumentHtml.html", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/TableDocumentTxt.txt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant5()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("TableDocument.doc", "txt", "out/saveus/TableDocumentTxt.txt", "utf-8", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document form storage and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("StoredDocConversionWithStorage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/TableDocumentHtmlfixed.htmlfixed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LoadEncoding", "utf-8")]
        public virtual void ConvertDocumentFormStorageAndSaveToStorage_Variant6()
        {
            this.ConvertDocumentFormStorageAndSaveToStorage("TableDocument.doc", "htmlfixed", "out/saveus/TableDocumentHtmlfixed.htmlfixed", "utf-8", ((string[])(null)));
        }
        
        public virtual void ConvertPdfDocumentToWordAndSaveToStorage(string docName, string destFormat, string outPath, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ConversionPdfToWord"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert pdf document to word and save to storage", @__tags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given(string.Format("I have uploaded document with name {0} to storage", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And(string.Format("I have specified save format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And(string.Format("I have specified document name {0} in URL", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And(string.Format("I have specified destFileName {0}", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I execute conversion from storage (POST SaveAs)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then(string.Format("document {0} is existed on storage", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert pdf document to word and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionPdfToWord")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "awesome_table_in_pdf.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "awesome_table_in_pdf.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/awesome_table_in_pdfDocx.docx")]
        public virtual void ConvertPdfDocumentToWordAndSaveToStorage_Awesome_Table_In_Pdf_Pdf()
        {
            this.ConvertPdfDocumentToWordAndSaveToStorage("awesome_table_in_pdf.pdf", "docx", "out/saveus/awesome_table_in_pdfDocx.docx", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert pdf document to word and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionPdfToWord")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Delivery.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "Delivery.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/DeliveryDocx.docx")]
        public virtual void ConvertPdfDocumentToWordAndSaveToStorage_Delivery_Pdf()
        {
            this.ConvertPdfDocumentToWordAndSaveToStorage("Delivery.pdf", "docx", "out/saveus/DeliveryDocx.docx", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert pdf document to word and save to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stored document conversion with save result to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ConversionPdfToWord")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "45.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "45.pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/saveus/45Docx.docx")]
        public virtual void ConvertPdfDocumentToWordAndSaveToStorage_45_Pdf()
        {
            this.ConvertPdfDocumentToWordAndSaveToStorage("45.pdf", "docx", "out/saveus/45Docx.docx", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
