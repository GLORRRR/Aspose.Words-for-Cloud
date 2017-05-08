package com.aspose.words.cloud.fields;

import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.convert.AppendDocumentExample;
import com.aspose.words.model.FormFieldResponse;

public class InsertFormFieldsWordDocumentExample {

	public static void main(String[] args) {
		// ExStart: InsertFormFieldsWordDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleBlankWordDocument.docx";

			Integer sectionIndex = 0;
			Integer paragraphIndex = 0;
			String insertBeforeNode = "";
			String destFileName = "Updated-" + fileName;
			String storage = "";
			String folder = "";

			String xml = "<FormFieldTextInput>" + "<Name>MyName</Name>" + "<Enabled>true</Enabled>" + "<StatusText />"
					+ "<OwnStatus>false</OwnStatus>" + "<HelpText />" + "<OwnHelp>false</OwnHelp>"
					+ "<CalculateOnExit>true</CalculateOnExit>" + "<EntryMacro />" + "<ExitMacro />"
					+ "<TextInputFormat>UPPERCASE</TextInputFormat>" + "<TextInputType>Regular</TextInputType>"
					+ "<TextInputDefault>Farooq Sheikh</TextInputDefault>" + "</FormFieldTextInput>";

			Path p1=Utils.getPath(AppendDocumentExample.class, fileName);
			
			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					p1.toFile());

			// invoke Aspose.Words Cloud SDK API to add field in the document
			FormFieldResponse apiResponse = wordsApi.PutFormField(fileName, sectionIndex, paragraphIndex,
					insertBeforeNode, destFileName, storage, folder, xml.getBytes("UTF-8"));

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Form field has been added successfully");

				// download updated file from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);

				InputStream responseStream = storageRes.getInputStream();

				final Path destination = Paths.get("./" + destFileName);

				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: InsertFormFieldsWordDocumentExample
	}

}
