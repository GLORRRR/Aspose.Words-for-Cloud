﻿namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.PutConvert.Steps
{
    using System;
    using System.IO;
   
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Requests;   

    using TechTalk.SpecFlow;

    /// <summary>
    /// It's "PutConvert" step class with injection of conversion context
    /// </summary>
    [Binding]
    public class PutConvertSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected PutConvertSteps(BaseContext context)
        {
            this.context = context;
        }

        private PutConvertDocumentRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as PutConvertDocumentRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PutConvert")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PutConvertDocumentRequest();
        }

        /// <summary>
        /// Sets the name of document
        /// </summary>
        /// <param name="documentName">name of document</param>
        [Given(@"I have specified document (.*) to send it in request body")]
        public void GivenIHaveSpecifiedDocumentTableDocumentToSendItInRequestBody(string documentName)
        {
            using (var fileStream = File.OpenRead(Path.Combine(this.context.TestDataPath, documentName)))
            {
                this.Request.Document = new MemoryStream();
                fileStream.CopyTo(this.Request.Document);               
            }            
        }

        /// <summary>
        /// Sets destination format
        /// </summary>
        /// <param name="destinationFormat">format document to be converted in</param>
        [Given(@"I have specified format (.*) document to be converted")]
        public void GivenIHaveSpecifiedFormatDocumentToBeConverted(string destinationFormat)
        {
            this.Request.Format = destinationFormat;
        }

        /// <summary>
        /// Sets encoding for conversion
        /// </summary>
        /// <param name="encoding">encoding</param>
        [Given(@"I have specified encoding (.*)")]
        public void GivenIHaveSpecifiedEncoding(string encoding)
        {
            // TODO: add LoadEncoding parameter or fix scenario
            //this.Context.Request.LoadEncoding = encoding;
        }

        /// <summary>
        /// Sets output name for converted document
        /// </summary>
        /// <param name="outPath">name for converted document</param>
        [Given(@"I have specified output path (.*)")]
        public void GivenIHaveSpecifiedOutputPath(string outPath)
        {
            this.Request.OutPath = this.context.TestFolderInStorage + outPath;
        }        

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion")]
        public void WhenIExecuteConversion()
        {
            this.context.Response = this.context.WordsApi.PutConvertDocument(this.Request);          
        }
        
        /// <summary>
        /// Checks that document converted properly
        /// </summary>
        [Then(@"symbols are encoded properly")]
        public void ThenSymbolsAreEncodedProperly()
        {
            // TODO: what are you going to check here?
            throw new NotImplementedException();
        }                                     
    }
}