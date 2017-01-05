package com.aspose.words.cloud.paragraphs;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ParagraphLink;
import com.aspose.words.model.ParagraphLinkCollectionResponse;

public class ReadingAllParagraphsFromDocumentExample {

	public static void main(String[] args) {
		 try {
             // Instantiate Aspose Storage API SDK
             StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

             // Instantiate Aspose Words API SDK
             WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.                                                                                 appSID, true);

             // set input file name
             String fileName = "SampleWordDocument.docx";
             String storage = null;
             String folder = null;

             //upload input file to aspose cloud storage
             storageApi.PutCreate(fileName, "", "", new File(ReadingAllParagraphsFromDocumentExample.class.getResource("/" + fileName).toURI()));

             // invoke Aspose.Words Cloud SDK API to get list of paragraphs from a word document
             ParagraphLinkCollectionResponse apiResponse = wordsApi.GetDocumentParagraphs(fileName, storage, folder);

             if (apiResponse != null
                             && apiResponse.getStatus().equals("OK")) {

                      ParagraphLink docProperty = apiResponse.getParagraphs().getParagraphLinkList().get(0);

                     //display document paragraphs info
                     for (ParagraphLink docParagraphLink : apiResponse.getParagraphs().getParagraphLinkList())
                     {
                        System.out.println("Link : " + docParagraphLink.getLink());
                        System.out.println("Text : " + docParagraphLink.getText());
                     }
             }

     } catch (Exception e) {
             e.printStackTrace();
     }

	}

}
