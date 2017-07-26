#ExStart:
require 'aspose_words_cloud'

class WorkingWithTables

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

  def get_table
    file_name = "TableDocument.doc"
    upload_file(file_name)
      
    index = 1
    response = @words_api.get_table(file_name, index)
  end

end

workingWithTables = WorkingWithTables.new()
puts workingWithTables.get_table
#ExEnd:
