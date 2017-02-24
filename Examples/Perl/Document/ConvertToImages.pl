#ExStart:1
use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;
use AsposeWordsCloud::WordsApi;
use AsposeWordsCloud::ApiClient;
use AsposeWordsCloud::Configuration;
use AsposeWordsCloud::Object::SaveOptionsData;

my $configFile = '../Config/config.json';
my $configPropsText = read_file($configFile);
my $configProps = decode_json($configPropsText);
my $data_path = '../../../Data/';
my $out_path = $configProps->{'out_folder'};

$AsposeWordsCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeWordsCloud::Configuration::api_key = $configProps->{'api_key'};
$AsposeWordsCloud::Configuration::debug = 1;
$AsposeStorageCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeStorageCloud::Configuration::api_key = $configProps->{'api_key'};

# Instantiate Aspose.Storage and Aspose.Words API SDK
my $storageApi = AsposeStorageCloud::StorageApi->new();
my $wordsApi = AsposeWordsCloud::WordsApi->new();

# Set input file name
my $filename = "SampleWordDocument";
my $name = $filename . ".docx";
my $format = "html";
my $outfilename = "SampleWordDocumentOutput.html";	

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);
my $saveOptionsData = AsposeWordsCloud::Object::SaveOptionsData->new('SaveFormat' => 'html', 'PrettyFormat' => 'True', 'FileName' => $outfilename);
# Invoke Aspose.Words Cloud SDK API to convert words document to required format with additional settings       
$response = $wordsApi->PostDocumentSaveAs(name=> $name, body=>$saveOptionsData);

if($response->{'Status'} eq 'OK'){
	# Download output document from storage server 
	$response = $storageApi->GetDownload(Path => $outfilename);	
	my $output_file = $out_path. $outfilename;	
	write_file($output_file, { binmode => ":raw" }, $response->{'Content'});
	}
#ExEnd:1