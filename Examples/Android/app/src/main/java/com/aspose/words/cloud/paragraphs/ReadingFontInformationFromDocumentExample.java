package com.aspose.words.cloud.paragraphs;

import java.io.File;

import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Font;
import com.aspose.words.model.FontResponse;

public class ReadingFontInformationFromDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ReadingFontInformationFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			Integer index = 0;
			Integer runIndex = 0;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",input);

			// invoke Aspose.Words Cloud SDK API to get a font related
			// information of a specific run of a paragraph from a word document
			FontResponse apiResponse = wordsApi.GetDocumentParagraphRunFont(fileName, index, runIndex, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				Font runFont = apiResponse.getFont();
				// display run font info
				if (runFont != null) {
					System.out.println("Font Name : " + runFont.getName());
					System.out.println("Style : " + runFont.getStyleName());
					System.out.println("Size : " + runFont.getSize());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingFontInformationFromDocumentExample

	}

}
