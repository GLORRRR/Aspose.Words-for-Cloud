require 'aspose_words_cloud'

class MailMerge

  include AsposeWordsCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @words_api = WordsApi.new
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def populate_document_template_with_data
    file_name = "SampleExecuteTemplate.doc"
    upload_file(file_name)

    response = @words_api.post_execute_template(file_name, File.open("../data/SampleExecuteTemplateData.txt","r") { |io| io.read })
  end

end

mailMerge = MailMerge.new()
puts mailMerge.populate_document_template_with_data