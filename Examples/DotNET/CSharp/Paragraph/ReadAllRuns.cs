﻿using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Paragraph
{
    class ReadAllRuns
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "GetField.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            string storage = null;
            string folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to read all Runs from a Paragraph in a Word Document
                ResponseMessage apiResponse = wordsApi.GetParagraphRuns(fileName, sectionIndex, paragraphIndex, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("Ok"))
                {
                    Console.WriteLine("Read all Runs from a Paragraph in a Word Document, Done!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
