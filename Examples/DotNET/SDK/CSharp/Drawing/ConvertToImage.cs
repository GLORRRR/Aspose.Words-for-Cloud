﻿using System;
using Aspose.Cloud;

namespace CSharp.Drawing
{
    class ConvertToImage
    {
        public static void Run()
        {
            string subdirectory = "Drawing";

            // The path to the documents directory.
            string dataDir = Common.GetDataDir() +  subdirectory + "\\";
            
            string inputfile = "testfile.doc";
            string outputfile = "testfile_out_.png";
            
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            dataDir = dataDir + outputfile;

            // Convert Drawing Object to Image
            Common.WordsService.WordsDrawingObjects.ConvertToFormatSpecified(inputfile, 0, WordDrawingObjectsFormat.Png, dataDir, Common.FOLDER);
                        
            Console.WriteLine("\nDrawing object converted successfully to png format.\nFile saved at " + dataDir);
        }
    }
}
