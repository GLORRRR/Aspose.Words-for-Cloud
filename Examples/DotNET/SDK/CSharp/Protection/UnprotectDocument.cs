﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Protection
{
    class UnprotectDocument
    {
        public static void Run()
        {
            string inputfile = "doc-sample-unprotect.doc";
            string subdirection = "Protection";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Unprotect a Word Document
            WordsProtectionRequest wordsProtectionRequest3 = new WordsProtectionRequest("aspose", string.Empty, ProtectionType.NoProtection);
            Common.WordsService.WordsDocumentProtection.UnprotectDocument(inputfile, Common.GetOutputFilePath(inputfile, true), wordsProtectionRequest3, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirection);

            Console.WriteLine("\nDocument unprotected successfully.\nFile saved at " + dataDir);
        }
    }
}
