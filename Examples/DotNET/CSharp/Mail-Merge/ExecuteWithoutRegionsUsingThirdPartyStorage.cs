﻿using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Mail_Merge
{
    class ExecuteWithoutRegionsUsingThirdPartyStorage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "TestExecuteTemplate.doc";
            string cleanup = null;
            string destFileName = "updated-" + fileName;
            string mailMergeDataFile = null;
            string storage = "dropboxstorage";
            string folder = null;
            bool useWholeParagraphAsRegion = false;
            bool withRegions = false;
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + "SampleMailMergeTemplateData.txt");

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to execute mail merge template without regions using third party storage
                DocumentResponse apiResponse = wordsApi.PostDocumentExecuteMailMerge(fileName, withRegions, mailMergeDataFile, cleanup, destFileName, storage, folder, useWholeParagraphAsRegion, file);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("mail merge template has been executed successfully");
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
