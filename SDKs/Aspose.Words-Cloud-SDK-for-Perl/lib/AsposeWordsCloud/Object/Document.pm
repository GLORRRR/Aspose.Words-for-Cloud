package AsposeWordsCloud::Object::Document;

require 5.6.0;
use strict;
use warnings;
use utf8;
use JSON qw(decode_json);
use Data::Dumper;
use Module::Runtime qw(use_module);
use Log::Any qw($log);
use Date::Parse;
use DateTime;

use base "AsposeWordsCloud::Object::BaseObject";

#
#
#
#NOTE: This class is auto generated by the swagger code generator program. Do not edit the class manually.
#

my $swagger_types = {
    'Links' => 'ARRAY[Link]',
    'FileName' => 'string',
    'SourceFormat' => 'DocumentFormat',
    'IsEncrypted' => 'boolean',
    'IsSigned' => 'boolean',
    'DocumentProperties' => 'DocumentProperties'
};

my $attribute_map = {
    'Links' => 'Links',
    'FileName' => 'FileName',
    'SourceFormat' => 'SourceFormat',
    'IsEncrypted' => 'IsEncrypted',
    'IsSigned' => 'IsSigned',
    'DocumentProperties' => 'DocumentProperties'
};

# new object
sub new { 
    my ($class, %args) = @_; 
    my $self = { 
        #
        'Links' => $args{'Links'}, 
        #
        'FileName' => $args{'FileName'}, 
        #
        'SourceFormat' => $args{'SourceFormat'}, 
        #
        'IsEncrypted' => $args{'IsEncrypted'}, 
        #
        'IsSigned' => $args{'IsSigned'}, 
        #
        'DocumentProperties' => $args{'DocumentProperties'}
    }; 

    return bless $self, $class; 
}  

# get swagger type of the attribute
sub get_swagger_types {
    return $swagger_types;
}

# get attribute mappping
sub get_attribute_map {
    return $attribute_map;
}

1;
