package com.aspose.words.cloud.fields;

import java.io.File;

import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.FieldNamesResponse;

public class GetMergeFieldsFromDocumentExample {
	public static void execute(Context context) throws Exception {
		// ExStart: GetMergeFieldsFromDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleMailMergeTemplate.docx";
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(GetMergeFieldsFromDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get merge field names from a
			// word document
			FieldNamesResponse apiResponse = wordsApi.GetDocumentFieldNames(fileName, false, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// Get all merge field names from document
				for (String fieldName : apiResponse.getFieldNames().getNames()) {
					System.out.println(fieldName);

				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GetMergeFieldsFromDocumentExample
	}
}
