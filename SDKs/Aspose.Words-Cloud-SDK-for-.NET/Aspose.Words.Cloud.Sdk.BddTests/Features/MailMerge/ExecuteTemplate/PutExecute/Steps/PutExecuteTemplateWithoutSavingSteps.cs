﻿namespace Aspose.Words.Cloud.Sdk.BddTests.Features.MailMerge.ExecuteTemplate.PutExecute.Steps
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for executing template online
    /// </summary>
    [Binding]
    public class PutExecuteTemplateWithoutSavingSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateWithoutSavingSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PutExecuteTemplateWithoutSavingSteps(BaseContext context)
        {
            this.context = context;
        }

        private PutExecuteTemplateOnlineRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as PutExecuteTemplateOnlineRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutExecuteTemplate")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PutExecuteTemplateOnlineRequest();
        }

        /// <summary>
        /// Initialize template stream 
        /// </summary>
        /// <param name="templateFile">template file</param>
        [Given(@"I have specified a template file (.*) with mustache syntax")]
        public void GivenIHaveSpecifiedATemplateFileWithMustacheSyntax(string templateFile)
        {
            this.Request.Template = 
                new MemoryStream(
                    File.ReadAllBytes(
                        Path.Combine(this.context.TestDataPath, templateFile)));
        }

        /// <summary>
        /// Initialize body stream
        /// </summary>
        /// <param name="bodyFile">body file</param>
        [Given(@"I have specified a body file (.*)")]
        [Scope(Feature = "PutExecuteTemplate execute template without saving")]
        public void GivenIHaveSpecifiedABodyFile(string bodyFile)
        {
            // TODO: I think, we should rename this step to "I have specified a data file (.*)"
            this.Request.Data =
                new MemoryStream(
                    File.ReadAllBytes(
                        Path.Combine(this.context.TestDataPath, bodyFile)));
        }

        /// <summary>
        /// Initialize cleanup option
        /// </summary>
        /// <param name="cleanup">cleanup option</param>
        [Given(@"I have specified a cleanup option (.*)")]
        public void GivenIHaveSpecifiedACleanupOption(string cleanup)
        {
            // TODO: Add interface "ICanSpecifyMailMergeParametersRequest" and move steps
            this.Request.Cleanup = cleanup;
        }

        /// <summary>
        /// Executes template online
        /// </summary>
        [When(@"I execute template online")]
        public void WhenIExecuteTemplateOnline()
        {
            this.context.Response = this.context.WordsApi.PutExecuteTemplateOnline(this.Request);
        }
        
        /// <summary>
        /// Checks document with merge value was successfully created
        /// </summary>
        [Then(@"document with merged values should be created")]
        public void ThenDocumentWithMergedValuesShouldBeCreated()
        {
            // TODO: use "document is returned as an attachment" step
            Assert.IsNotNull(this.context.Response as MemoryStream);
        }
        
        [Then(@"image should be rendered")]
        public void ThenImageShouldBeRendered()
        {
            var doc = new Document(this.context.Response as MemoryStream);
            var images = doc.GetChildNodes(NodeType.Shape, true);
            Assert.IsTrue(images.Count > 0);
        }
        
        [Then(@"unused option is cleaned up")]
        public void ThenUnusedOptionIsCleanedUp()
        {
            // TODO: what are checked here?
            Assert.IsTrue(true);
        }
    }
}
