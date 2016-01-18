﻿using System;
using Aspose.Cloud;

namespace CSharp.Watermark
{
    class AddText
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc"; 

            string outfile = Common.GetOutputFilePath(inputfile, true);
            
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Add Watermark Text to a Word Document
            Common.WordsService.WordsDocumentWatermark.InsertDocumentWatermarkText(inputfile, "Watermarked by Aspose", 45.0, outfile, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nWatermark text added successfully.\nFile saved at " + dataDir);
        }
    }
}
