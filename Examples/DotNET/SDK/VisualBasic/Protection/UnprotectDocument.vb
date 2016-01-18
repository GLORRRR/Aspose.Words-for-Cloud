﻿Imports Aspose.Cloud

Namespace Protection
    Class UnprotectDocument
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample-unprotect.doc"
            Dim subdirection As String = "Protection"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Unprotect a Word Document
            Dim wordsProtectionRequest3 As New WordsProtectionRequest("aspose", String.Empty, ProtectionType.NoProtection)
            Common.WordsService.WordsDocumentProtection.UnprotectDocument(inputfile, Common.GetOutputFilePath(inputfile, True), wordsProtectionRequest3, Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, subdirection)

            Console.WriteLine(Convert.ToString(vbLf & "Document unprotected successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace