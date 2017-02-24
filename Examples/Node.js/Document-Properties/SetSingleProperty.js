// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var WordsApi = require('asposewordscloud');
var configProps = require('../Config/config.json');
var data_path = '../../../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi(config);

// Set input file name
var name = "SampleWordDocument.docx";
var propertyName = "Author";
var DocumentPropertyBody = {
		'Name' : 'Author',
		'Value' : 'Naeem Akram'
		};
try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to update document property by given name from a word document
	wordsApi.PutUpdateDocumentProperty(name, propertyName, null, null, null, DocumentPropertyBody, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			
			// Display document property info
			var docProperty = responseMessage.body.DocumentProperty
			console.log(docProperty.Name + " : " +   docProperty.Value);
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1