#!/usr/bin/env python

class ProtectionDataResponse(object):
    """NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually."""


    def __init__(self):
        """
        Attributes:
          swaggerTypes (dict): The key is attribute name and the value is attribute type.
          attributeMap (dict): The key is attribute name and the value is json key in definition.
        """
        self.swaggerTypes = {
            'ProtectionData': 'ProtectionData',
            'DocumentLink': 'Link',
            'Code': 'str',
            'Status': 'str'

        }

        self.attributeMap = {
            'ProtectionData': 'ProtectionData','DocumentLink': 'DocumentLink','Code': 'Code','Status': 'Status'}       

        self.ProtectionData = None # ProtectionData
        self.DocumentLink = None # Link
        self.Code = None # str
        self.Status = None # str
        