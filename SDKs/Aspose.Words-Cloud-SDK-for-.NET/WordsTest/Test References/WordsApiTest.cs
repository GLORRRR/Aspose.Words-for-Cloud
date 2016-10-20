﻿using Com.Aspose.Words.Api;
using Com.Aspose.Storage.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordsTest
{


    /// <summary>
    ///This is a test class for TestWordsApi and is intended
    ///to contain all TestWordsApi Unit Tests
    ///</summary>
    [TestClass()]
    public class TestWordsApi
    {
        private TestContext testContextInstance;

        protected WordsApi target;
        protected StorageApi storageApi;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for WordsApi Constructor
        ///</summary>
        public TestWordsApi()
        {
            target = new WordsApi("xxx", "xxx", "http://api.aspose.com/v1.1");
            storageApi = new StorageApi("xxx", "xxx", "http://api.aspose.com/v1.1");

        }

        /// <summary>
        ///A test for AcceptAllRevisions
        ///</summary>
        [TestMethod()]
        public void TestAcceptAllRevisions()
        {

            string name = "test_multi_pages.docx";
            string filename = "Test2.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.RevisionsModificationResponse actual;
            actual = target.AcceptAllRevisions(name, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.RevisionsModificationResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteComment
        ///</summary>
        [TestMethod()]
        public void TestDeleteComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 1; 
            string storage = null;
            string folder = null;
            string fileName = "test_multi_pages.docx";
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteComment(name, commentIndex, storage, folder, fileName);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteDocumentFields
        ///</summary>
        [TestMethod()]
        public void TestDeleteDocumentFields()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteDocumentFields(name, storage, folder);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteDocumentMacros
        ///</summary>
        [TestMethod()]
        public void TestDeleteDocumentMacros()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteDocumentMacros(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteDocumentProperty
        ///</summary>
        [TestMethod()]
        public void TestDeleteDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "AsposeAuthor";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.DocumentProperty body = new Com.Aspose.Words.Model.DocumentProperty();
            body.Name = "AsposeAuthor";
            body.Value = "Imran Anwar";
            body.BuiltIn = false;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            //setting a property
            target.PutUpdateDocumentProperty(name, propertyName, filename, storage, folder, body);

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteDocumentProperty(name, propertyName, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteDocumentWatermark
        ///</summary>
        [TestMethod()]
        public void TestDeleteDocumentWatermark()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.DeleteDocumentWatermark(name, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteFormField
        ///</summary>
        [TestMethod()]
        public void TestDeleteFormField()
        {
            string name = "FormFilled.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            int formfieldIndex = 0;
            string destFileName = "FormFilledTest.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteFormField(name, sectionIndex, paragraphIndex, formfieldIndex, destFileName, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteHeadersFooters
        ///</summary>
        [TestMethod()]
        public void TestDeleteHeadersFooters()
        {
            string name = "test_multi_pages.docx";
            string headersFootersTypes = null;
            string filename = "test.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteHeadersFooters(name, headersFootersTypes, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteParagraphFields
        ///</summary>
        [TestMethod()]
        public void TestDeleteParagraphFields()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteParagraphFields(name, index, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteSectionFields
        ///</summary>
        [TestMethod()]
        public void TestDeleteSectionFields()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; // TODO: Initialize to an appropriate value
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteSectionFields(name, sectionIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType());             
        }

        /// <summary>
        ///A test for DeleteSectionParagraphFields
        ///</summary>
        [TestMethod()]
        public void TestDeleteSectionParagraphFields()
        {

            string name = "test_multi_pages.docx";
            int sectionIndex = 0; // TODO: Initialize to an appropriate value
            int paragraphIndex = 0; // TODO: Initialize to an appropriate value
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SaaSposeResponse actual;
            actual = target.DeleteSectionParagraphFields(name, sectionIndex, paragraphIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaaSposeResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for DeleteUnprotectDocument
        ///</summary>
        [TestMethod()]
        public void TestDeleteUnprotectDocument()
        {
            string name = "SampleProtectedBlankDoc.docx";
            string filename = null;
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.ProtectionRequest body = new Com.Aspose.Words.Model.ProtectionRequest();
            body.Password = "aspose";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.ProtectionDataResponse actual;
            actual = target.DeleteUnprotectDocument(name, filename, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ProtectionDataResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetComment
        ///</summary>
        [TestMethod()]
        public void TestGetComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 1;
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.CommentResponse actual;
            actual = target.GetComment(name, commentIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.CommentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetComments
        ///</summary>
        [TestMethod()]
        public void TestGetComments()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.CommentsResponse actual;
            actual = target.GetComments(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.CommentsResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocument
        ///</summary>
        [TestMethod()]
        public void TestGetDocument()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocument(name, storage, folder);

            Assert.AreNotEqual(actual, "");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentBookmarkByName
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentBookmarkByName()
        {

            string name = "test_multi_pages.docx";
            string bookmarkName = "aspose";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.BookmarkResponse actual;
            actual = target.GetDocumentBookmarkByName(name, bookmarkName, storage, folder);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.BookmarkResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentBookmarks
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentBookmarks()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.BookmarksResponse actual;
            actual = target.GetDocumentBookmarks(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.BookmarksResponse(), actual.GetType());              
        }

        /// <summary>
        ///A test for GetDocumentDrawingObjectByIndex
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentDrawingObjectByIndex()
        {
            string name = "test_multi_pages.docx";
            int objectIndex = 0;
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocumentDrawingObjectByIndex(name, objectIndex, storage, folder);

            Assert.AreNotEqual(actual, "");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentDrawingObjectByIndexWithFormat
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentDrawingObjectByIndexWithFormat()
        {




            string name = "test_multi_pages.docx";
            int objectIndex = 0;
            string format = "png";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocumentDrawingObjectByIndexWithFormat(name, objectIndex, format, storage, folder);

            Assert.AreNotEqual(actual, "");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentDrawingObjectImageData
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentDrawingObjectImageData()
        {
            string name = "test_multi_pages.docx";
            int objectIndex = 0;
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocumentDrawingObjectImageData(name, objectIndex, storage, folder);

        Assert.AreNotEqual(actual, "");
        Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentDrawingObjectOleData
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentDrawingObjectOleData()
        {
            string name = "sample_EmbeddedOLE.docx";
            int objectIndex = 0; 
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocumentDrawingObjectOleData(name, objectIndex, storage, folder);

            Assert.AreNotEqual(actual, "");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentDrawingObjects
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentDrawingObjects()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DrawingObjectsResponse actual;
            actual = target.GetDocumentDrawingObjects(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DrawingObjectsResponse(), actual.GetType()); 

            
        }

        /// <summary>
        ///A test for GetDocumentFieldNames
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentFieldNames()
        {
            string name = name = "test_multi_pages.docx";
            bool useNonMergeFields = false;
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FieldNamesResponse actual;
            actual = target.GetDocumentFieldNames(name, useNonMergeFields, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FieldNamesResponse(), actual.GetType());             
        }

        /// <summary>
        ///A test for GetDocumentHyperlinkByIndex
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentHyperlinkByIndex()
        {
            string name = "test_doc.docx";
            int hyperlinkIndex = 0;
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.HyperlinkResponse actual;
            actual = target.GetDocumentHyperlinkByIndex(name, hyperlinkIndex, storage, folder);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.HyperlinkResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentHyperlinks
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentHyperlinks()
        {
            string name = "test_doc.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.HyperlinksResponse actual;
            actual = target.GetDocumentHyperlinks(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.HyperlinksResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentParagraph
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentParagraph()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ParagraphResponse actual;
            actual = target.GetDocumentParagraph(name, index, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ParagraphResponse(), actual.GetType()); 

            
        }

        /// <summary>
        ///A test for GetDocumentParagraphRun
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentParagraphRun()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            int runIndex = 0; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.RunResponse actual;
            actual = target.GetDocumentParagraphRun(name, index, runIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.RunResponse(), actual.GetType()); 

            
        }

        /// <summary>
        ///A test for GetDocumentParagraphRunFont
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentParagraphRunFont()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            int runIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FontResponse actual;
            actual = target.GetDocumentParagraphRunFont(name, index, runIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FontResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentParagraphs
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentParagraphs()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ParagraphLinkCollectionResponse actual;
            actual = target.GetDocumentParagraphs(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ParagraphLinkCollectionResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentProperties
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentProperties()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentPropertiesResponse actual;
            actual = target.GetDocumentProperties(name, storage, folder);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentPropertiesResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentProperty
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "Author";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentPropertyResponse actual;
            actual = target.GetDocumentProperty(name, propertyName, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentPropertyResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentProtection
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentProtection()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ProtectionDataResponse actual;
            actual = target.GetDocumentProtection(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ProtectionDataResponse(), actual.GetType());

        }

        /// <summary>
        ///A test for GetDocumentStatistics
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentStatistics()
        {
            string name = "test_multi_pages.docx";
            bool includeComments = false;
            bool includeFootnotes = false;
            bool includeTextInShapes = false;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.StatDataResponse actual;
            actual = target.GetDocumentStatistics(name, includeComments, includeFootnotes, includeTextInShapes, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.StatDataResponse(), actual.GetType());             
        }

        /// <summary>
        ///A test for GetDocumentTextItems
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentTextItems()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.TextItemsResponse actual;
            actual = target.GetDocumentTextItems(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.TextItemsResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetDocumentWithFormat
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentWithFormat()
        {
            string name = "test_multi_pages.docx";
            string format = "text";
            string storage = null;
            string folder = null;
            string outPath = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.GetDocumentWithFormat(name, format, storage, folder, outPath);

            Assert.AreNotEqual(actual, "");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetField
        ///</summary>
        [TestMethod()]
        public void TestGetField()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; 
            int paragraphIndex = 0;
            int fieldIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FieldResponse actual;
            actual = target.GetField(name, sectionIndex, paragraphIndex, fieldIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetFormField
        ///</summary>
        [TestMethod()]
        public void TestGetFormField()
        {
            string name = "FormFilled.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            int formfieldIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FormFieldResponse actual;
            actual = target.GetFormField(name, sectionIndex, paragraphIndex, formfieldIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FormFieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetSection
        ///</summary>
        [TestMethod()]
        public void TestGetSection()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SectionResponse actual;
            actual = target.GetSection(name, sectionIndex, storage, folder);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SectionResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetSectionPageSetup
        ///</summary>
        [TestMethod()]
        public void TestGetSectionPageSetup()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SectionPageSetupResponse actual;
            actual = target.GetSectionPageSetup(name, sectionIndex, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SectionPageSetupResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for GetSections
        ///</summary>
        [TestMethod()]
        public void TestGetSections()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SectionLinkCollectionResponse actual;
            actual = target.GetSections(name, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SectionLinkCollectionResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostAppendDocument
        ///</summary>
        [TestMethod()]
        public void TestPostAppendDocument()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.DocumentEntryList body = new Com.Aspose.Words.Model.DocumentEntryList();
            System.Collections.Generic.List<Com.Aspose.Words.Model.DocumentEntry> docEntries = new System.Collections.Generic.List<Com.Aspose.Words.Model.DocumentEntry> { };

            Com.Aspose.Words.Model.DocumentEntry docEntry = new Com.Aspose.Words.Model.DocumentEntry();
            docEntry.Href = "test_multi_pages.docx";
            docEntry.ImportFormatMode = "KeepSourceFormatting";
            docEntries.Add(docEntry);
            body.DocumentEntries = docEntries;            

             storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostAppendDocument(name, filename, storage, folder, body);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostChangeDocumentProtection
        ///</summary>
        [TestMethod()]
        public void TestPostChangeDocumentProtection()
        {
            string name = "test_multi_pages.docx";
            string filename = null;
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.ProtectionRequest body = new Com.Aspose.Words.Model.ProtectionRequest();
            body.NewPassword = "";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ProtectionDataResponse actual;
            actual = target.PostChangeDocumentProtection(name, filename, storage, folder, body);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ProtectionDataResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostComment
        ///</summary>
        [TestMethod()]
        public void TestPostComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 0;
            string fileName = null;
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.CommentDto body = new Com.Aspose.Words.Model.CommentDto();

            Com.Aspose.Words.Model.DocumentPositionDto dpdto = new Com.Aspose.Words.Model.DocumentPositionDto();
            Com.Aspose.Words.Model.NodeLink nodeLink = new Com.Aspose.Words.Model.NodeLink();
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();

            dpdto.Node = nodeLink;
            dpdto.Offset = 0;
            nodeLink.link = lnk;
            nodeLink.NodeId = "0.0.3";

            body.RangeStart = dpdto;
            body.RangeEnd = dpdto;

            body.Initial = "IA";
            body.Author = "Imran Anwar";
            body.Text = "A new Comment";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.CommentResponse actual;
            actual = target.PostComment(name, commentIndex, fileName, storage, folder, body);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.CommentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostDocumentExecuteMailMerge
        ///</summary>
        [TestMethod()]
        public void TestPostDocumentExecuteMailMerge()
        {
            string name = "SampleMailMergeTemplate.docx";
            bool withRegions = false;
            string mailMergeDataFile = null;
            string cleanup = null;
            string filename = "SampleMailMergeResult.docx";
            string storage = null;
            string folder = null;
            bool useWholeParagraphAsRegion = false;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + "SampleMailMergeTemplateData.txt");

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostDocumentExecuteMailMerge(name, withRegions, mailMergeDataFile, cleanup, filename, storage, folder, useWholeParagraphAsRegion, file);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostDocumentParagraphRunFont
        ///</summary>
        [TestMethod()]
        public void TestPostDocumentParagraphRunFont()
        {
            string name = "test_multi_pages.docx";
            int index = 0; // TODO: Initialize to an appropriate value
            int runIndex = 0; // TODO: Initialize to an appropriate value
            string storage = null;
            string folder = null;
            string filename = "test.docx";
            Com.Aspose.Words.Model.Font body = new Com.Aspose.Words.Model.Font();
            body.Bold = true;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FontResponse actual;
            actual = target.PostDocumentParagraphRunFont(name, index, runIndex, storage, folder, filename, body);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FontResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostDocumentSaveAs
        ///</summary>
        [TestMethod()]
        public void TestPostDocumentSaveAs()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.SaveOptionsData body = new Com.Aspose.Words.Model.SaveOptionsData();

            body.SaveFormat = "pdf";
            body.FileName = "output.pdf";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.SaveResponse actual;
            actual = target.PostDocumentSaveAs(name, storage, folder, body);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaveResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostExecuteTemplate
        ///</summary>
        [TestMethod()]
        public void TestPostExecuteTemplate()
        {
            string name = "TestExecuteTemplate.doc";
            string cleanup = null;
            string destFileName = "TestExecuteResult.doc";
            string storage = null;
            string folder = null;
            bool useWholeParagraphAsRegion = false; // TODO: Initialize to an appropriate value
            bool withRegions = false; // TODO: Initialize to an appropriate value
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + "TestExecuteTemplateData.txt");

             storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostExecuteTemplate(name, cleanup, destFileName, storage, folder, useWholeParagraphAsRegion, withRegions, file);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostField
        ///</summary>
        [TestMethod()]
        public void TestPostField()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; // TODO: Initialize to an appropriate value
            int paragraphIndex = 0; // TODO: Initialize to an appropriate value
            int fieldIndex = 1; // TODO: Initialize to an appropriate value
            string destFileName = "newSampleWordDocument.docx";
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.FieldDto body = new Com.Aspose.Words.Model.FieldDto();
            body.Result = "3";
            body.FieldCode = "{ NUMPAGES }";
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();
            body.NodeId = "0.0.3";
            body.link = lnk;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.FieldResponse actual;
            actual = target.PostField(name, sectionIndex, paragraphIndex, fieldIndex, destFileName, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostFormField
        ///</summary>
        [TestMethod()]
        public void TestPostFormField()
        {
            string name = "FormFilled.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            int formfieldIndex = 0;
            string destFileName = "newFormFilled.docx";
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.FormField body = new Com.Aspose.Words.Model.FormField();
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();
            lnk.Href = "";

            body.Name = "FullName";
            body.Enabled = true;
            body.CalculateOnExit = true;
            body.StatusText = "";
            body.link = lnk;
            body.TextInputType = "Regular";
            body.TextInputDefault = "";



            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FormFieldResponse actual;
            actual = target.PostFormField(name, sectionIndex, paragraphIndex, formfieldIndex, destFileName, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FormFieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostInsertDocumentWatermarkImage
        ///</summary>
        [TestMethod()]
        public void TestPostInsertDocumentWatermarkImage()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            double rotationAngle = 0F;
            string image = "aspose-cloud.png";
            string storage = null;
            string folder = null;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + image);
             storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostInsertDocumentWatermarkImage(name, filename, rotationAngle, image, storage, folder, file);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostInsertDocumentWatermarkText
        ///</summary>
        [TestMethod()]
        public void TestPostInsertDocumentWatermarkText()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            string text = "Aspose Watermark";
            double rotationAngle = 0F;
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.WatermarkText body = new Com.Aspose.Words.Model.WatermarkText();
            body.Text = "The watermark of Aspose";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostInsertDocumentWatermarkText(name, filename, text, rotationAngle, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostInsertPageNumbers
        ///</summary>
        [TestMethod()]
        public void TestPostInsertPageNumbers()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.PageNumber body = new Com.Aspose.Words.Model.PageNumber();
            body.Alignment = "center";
            body.Format = "{PAGE} of {NUMPAGES}";
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostInsertPageNumbers(name, filename, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostInsertWatermarkImage
        ///</summary>
        [TestMethod()]
        public void TestPostInsertWatermarkImage()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            double rotationAngle = 0F; // TODO: Initialize to an appropriate value
            string image = "aspose-cloud.png";
            string storage = null;
            string folder = null;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + image);
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostInsertWatermarkImage(name, filename, rotationAngle, image, storage, folder, file);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostInsertWatermarkText
        ///</summary>
        [TestMethod()]
        public void TestPostInsertWatermarkText()
        {
            string name = "test_multi_pages.docx";
            string text = "New";
            double rotationAngle = 90.0F; // TODO: Initialize to an appropriate value
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.WatermarkText body = new Com.Aspose.Words.Model.WatermarkText();
            body.Text = "This is the text";
            body.RotationAngle = 90.0f;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostInsertWatermarkText(name, text, rotationAngle, filename, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostLoadWebDocument
        ///</summary>
        [TestMethod()]
        public void TestPostLoadWebDocument()
        {
            Com.Aspose.Words.Model.LoadWebDocumentData body = new Com.Aspose.Words.Model.LoadWebDocumentData();
            var soptions = new Com.Aspose.Words.Model.SaveOptionsData();
            soptions.FileName = "google.doc";
            soptions.SaveFormat = "doc";
            soptions.ColorMode = "1";
            soptions.DmlEffectsRenderingMode = "1";
            soptions.DmlRenderingMode = "1";
            soptions.UpdateSdtContent = false;
            soptions.ZipOutput = false;

            body.LoadingDocumentUrl = "http://google.com";
            body.SaveOptions = soptions;

            Com.Aspose.Words.Model.SaveResponse actual;
            actual = target.PostLoadWebDocument(body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaveResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostReplaceText
        ///</summary>
        [TestMethod()]
        public void TestPostReplaceText()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages_result.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.ReplaceTextRequest body = new Com.Aspose.Words.Model.ReplaceTextRequest();
            body.OldValue = "aspose";
            body.NewValue = "aspose new";

             storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.ReplaceTextResponse actual;
            actual = target.PostReplaceText(name, filename, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ReplaceTextResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostRunTask
        ///</summary>
        [TestMethod()]
        public void TestPostRunTask()
        {
            string name = "test_multi_pages.docx";
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + name);
            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.PostRunTask(file);

            Assert.AreEqual(actual, null);
            //Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostSplitDocument
        ///</summary>
        [TestMethod()]
        public void TestPostSplitDocument()
        {
            string name = "test_multi_pages.docx";
            string format = "text";
            int from = 1; 
            int to = 2; 
            bool zipOutput = false; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.SplitDocumentResponse actual;
            actual = target.PostSplitDocument(name, format, from, to, zipOutput, storage, folder);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SplitDocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostUpdateDocumentBookmark
        ///</summary>
        [TestMethod()]
        public void TestPostUpdateDocumentBookmark()
        {
            string name = "test_multi_pages.docx";
            string bookmarkName = "aspose";
            string filename = "test.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.BookmarkData body = new Com.Aspose.Words.Model.BookmarkData();
            body.Name = "aspose";
            body.Text = "This will be the text for Aspose";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.BookmarkResponse actual;
            actual = target.PostUpdateDocumentBookmark(name, bookmarkName, filename, storage, folder, body);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.BookmarkResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PostUpdateDocumentFields
        ///</summary>
        [TestMethod()]
        public void TestPostUpdateDocumentFields()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.DocumentResponse actual;
            actual = target.PostUpdateDocumentFields(name, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutComment
        ///</summary>
        [TestMethod()]
        public void TestPutComment()
        {
            string name = "test_multi_pages.docx";
            string fileName = null;
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.CommentDto body = new Com.Aspose.Words.Model.CommentDto();

            Com.Aspose.Words.Model.DocumentPositionDto dpdto = new Com.Aspose.Words.Model.DocumentPositionDto();
            Com.Aspose.Words.Model.NodeLink nodeLink = new Com.Aspose.Words.Model.NodeLink();
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();

            dpdto.Node = nodeLink;
            dpdto.Offset = 0;
            nodeLink.link = lnk;
            nodeLink.NodeId = "0.0.3";

            body.RangeStart = dpdto;
            body.RangeEnd = dpdto;

            body.Initial = "IA";
            body.Author = "Imran Anwar";
            body.Text = "A new Comment";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.CommentResponse actual;
            actual = target.PutComment(name, fileName, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.CommentResponse(), actual.GetType());             
        }

        /// <summary>
        ///A test for PutConvertDocument
        ///</summary>
        [TestMethod()]
        public void TestPutConvertDocument()
        {
            string format = "pdf";
            string outPath = null;
            string replaceResourcesHostTo = "new_pdf.pdf";
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\test_uploadfile.docx"); 
            
            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.PutConvertDocument(format, outPath, replaceResourcesHostTo, file);

            Assert.AreEqual(actual.Code, 200);
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutDocumentFieldNames
        ///</summary>
        [TestMethod()]
        public void TestPutDocumentFieldNames()
        {
            bool useNonMergeFields = false; // TODO: Initialize to an appropriate value
            
            Com.Aspose.Words.Model.FieldNamesResponse actual;
            actual = target.PutDocumentFieldNames(useNonMergeFields);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FieldNamesResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutDocumentSaveAsTiff
        ///</summary>
        [TestMethod()]
        public void TestPutDocumentSaveAsTiff()
        {
            string name = "test_multi_pages.docx";
            string resultFile = "test.docx";
            bool useAntiAliasing = false;
            bool useHighQualityRendering = false;
            float imageBrightness = 0F;
            string imageColorMode = null;
            float imageContrast = 0F;
            string numeralFormat = null;
            int pageCount = 0;
            int pageIndex = 0;
            string paperColor = null;
            string pixelFormat = null;
            float resolution = 0F;
            float scale = 0F;
            string tiffCompression = null;
            string dmlRenderingMode = null;
            string dmlEffectsRenderingMode = null;
            string tiffBinarizationMethod = null;
            string storage = null;
            string folder = null;
            bool zipOutput = false;
            Com.Aspose.Words.Model.TiffSaveOptionsData body = new Com.Aspose.Words.Model.TiffSaveOptionsData();
            body.FileName = "abc.tiff";
            body.SaveFormat = "tiff";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.SaveResponse actual;
            actual = target.PutDocumentSaveAsTiff(name, resultFile, useAntiAliasing, useHighQualityRendering, imageBrightness, imageColorMode, imageContrast, numeralFormat, pageCount, pageIndex, paperColor, pixelFormat, resolution, scale, tiffCompression, dmlRenderingMode, dmlEffectsRenderingMode, tiffBinarizationMethod, storage, folder, zipOutput, body);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SaveResponse(), actual.GetType());

        }

        /// <summary>
        ///A test for PutExecuteMailMergeOnline
        ///</summary>
        [TestMethod()]
        public void TestPutExecuteMailMergeOnline()
        {
            bool withRegions = false;
            string cleanup = null;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\SampleExecuteTemplate.docx");
            byte[] data = System.IO.File.ReadAllBytes("\\temp\\resources\\SampleExecuteTemplateData.txt");

                        
            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.PutExecuteMailMergeOnline(withRegions, cleanup, file, data);

            Assert.AreEqual(actual.Code, 200);
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutExecuteTemplateOnline
        ///</summary>
        [TestMethod()]
        public void TestPutExecuteTemplateOnline()
        {
            string cleanup = null;
            bool useWholeParagraphAsRegion = false;
            bool withRegions = false; 
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\SampleMailMergeTemplate.docx");
            byte[] data = System.IO.File.ReadAllBytes("\\temp\\resources\\SampleExecuteTemplateData.txt");

            Com.Aspose.Words.Model.ResponseMessage actual;
            actual = target.PutExecuteTemplateOnline(cleanup, useWholeParagraphAsRegion, withRegions, file, data);

            Assert.AreEqual(actual.Code, 200);
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ResponseMessage(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutField
        ///</summary>
        [TestMethod()]
        public void TestPutField()
        {

            string name = "SampleWordDocument.docx";
            int sectionIndex = 0; 
            int paragraphIndex = 0; 
            string insertBeforeNode = null;
            string destFileName = null;
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.FieldDto body = new Com.Aspose.Words.Model.FieldDto();
            body.Result = "3";
            body.FieldCode = "{ NUMPAGES }";
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();
            body.NodeId = "0.0.3";
            body.link = lnk;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.FieldResponse actual;
            actual = target.PutField(name, sectionIndex, paragraphIndex, insertBeforeNode, destFileName, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutFormField
        ///</summary>
        [TestMethod()]
        public void TestPutFormField()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; 
            int paragraphIndex = 0; 
            string insertBeforeNode = null;
            string destFileName = "test.docx";
            string storage = null;
            string folder = null;

            Com.Aspose.Words.Model.FormField body = new Com.Aspose.Words.Model.FormField();
            Com.Aspose.Words.Model.Link lnk = new Com.Aspose.Words.Model.Link();
            lnk.Href = "";

            body.Name = "FullName";
            body.Enabled = true;
            body.CalculateOnExit = true;
            body.StatusText = "";
            body.link = lnk;
            body.TextInputType = "Regular";
            body.TextInputDefault = "";
            body.TextInputFormat = "UPPERCASE";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            Com.Aspose.Words.Model.FormFieldResponse actual;
            actual = target.PutFormField(name, sectionIndex, paragraphIndex, insertBeforeNode, destFileName, storage, folder, body);

            Assert.AreEqual(actual.Code, "200"); 
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.FormFieldResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutProtectDocument
        ///</summary>
        [TestMethod()]
        public void TestPutProtectDocument()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.ProtectionRequest body = new Com.Aspose.Words.Model.ProtectionRequest(); 

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.ProtectionDataResponse actual;
            actual = target.PutProtectDocument(name, filename, storage, folder, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.ProtectionDataResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for PutUpdateDocumentProperty
        ///</summary>
        [TestMethod()]
        public void TestPutUpdateDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "Author";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            Com.Aspose.Words.Model.DocumentProperty body = new Com.Aspose.Words.Model.DocumentProperty();
            body.Name = "Author";
            body.Value = "Imran Anwar";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.DocumentPropertyResponse actual;
            actual = target.PutUpdateDocumentProperty(name, propertyName, filename, storage, folder, body);
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.DocumentPropertyResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for RejectAllRevisions
        ///</summary>
        [TestMethod()]
        public void TestRejectAllRevisions()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));

            Com.Aspose.Words.Model.RevisionsModificationResponse actual;
            actual = target.RejectAllRevisions(name, filename, storage, folder);

            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.RevisionsModificationResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void TestSearch()
        {
            string name = "SampleWordDocument.docx";
            string pattern = "aspose";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.SearchResponse actual;
            actual = target.Search(name, pattern, storage, folder);
            
            Assert.AreEqual(actual.Code, "200"); 
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SearchResponse(), actual.GetType()); 
            
        }

        /// <summary>
        ///A test for UpdateSectionPageSetup
        ///</summary>
        [TestMethod()]
        public void TestUpdateSectionPageSetup()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; 
            string storage = null;
            string folder = null;
            string filename = null;

            Com.Aspose.Words.Model.PageSetup body = new Com.Aspose.Words.Model.PageSetup();
            body.RtlGutter = true;
            body.LeftMargin = 10.0f;
            body.Orientation = "Landscape";
            body.PaperSize = "A5";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name));
            
            Com.Aspose.Words.Model.SectionPageSetupResponse actual;
            actual = target.UpdateSectionPageSetup(name, sectionIndex, storage, folder, filename, body);
            
            Assert.AreEqual(actual.Code, "200");
            Assert.IsInstanceOfType(new Com.Aspose.Words.Model.SectionPageSetupResponse(), actual.GetType()); 
            
        }


    }
}
