package com.aspose.words.cloud.sections;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.SectionLink;
import com.aspose.words.model.SectionLinkCollectionResponse;

public class ReadAllSectionsFromDocumentExample {

	public static void main(String[] args) {
		try{
            //Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID,true);

            //Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID,true);

            //set input file name
            String fileName = "SampleWordDocument.docx";

            String storage = null;
            String folder = null;

            //upload input file to aspose cloud storage
            storageApi.PutCreate(fileName, "", "", new File(ReadAllSectionsFromDocumentExample.class.getResource("/" + fileName).toURI()));

            //invoke Aspose.Words Cloud SDK API to get list of all sections present from a word document
             SectionLinkCollectionResponse apiResponse = wordsApi.GetSections(fileName, storage, folder);

            if(apiResponse!=null && apiResponse.getStatus().equals("OK")){
                    //get sections href
                    for( SectionLink sectionLink : apiResponse.getSections().getSectionLinkList()){
                            System.out.println(sectionLink.getLink().getHref());
                       }
            }

    }catch(Exception e){
            e.printStackTrace();
            }

	}

}
