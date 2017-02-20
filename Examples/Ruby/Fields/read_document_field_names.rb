#ExStart:
require 'aspose_words_cloud'

class Fields

  include AsposeWordsCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @words_api = WordsApi.new  
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
  end

  # Read document field names.
  def read_document_field_names
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    response = @words_api.get_document_field_names(file_name)
  end

end

fields = Fields.new()
puts fields.read_document_field_names
#ExEnd: