<?php
/**
 * Table
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */
/**
 *  Copyright 2015 SmartBear Software
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Aspose\Words\Models;

use \ArrayAccess;
/**
 * Table Class Doc Comment
 *
 * @category    Class
 * @description 
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class Table implements ArrayAccess
{
    /**
      * Array of property to type mappings. Used for (de)serialization 
      * @var string[]
      */
    static $swaggerTypes = array(
        'table_row_list' => '\Swagger\Client\Model\TableRow[]',
        'table_properties' => '\Swagger\Client\Model\TableProperties',
        'node_id' => 'string',
        'link' => '\Swagger\Client\Model\Link'
    );
  
    /** 
      * Array of attributes where the key is the local name, and the value is the original name
      * @var string[] 
      */
    static $attributeMap = array(
        'table_row_list' => 'TableRowList',
        'table_properties' => 'TableProperties',
        'node_id' => 'NodeId',
        'link' => 'link'
    );
  
    /**
      * Array of attributes to setter functions (for deserialization of responses)
      * @var string[]
      */
    static $setters = array(
        'table_row_list' => 'setTableRowList',
        'table_properties' => 'setTableProperties',
        'node_id' => 'setNodeId',
        'link' => 'setLink'
    );
  
    /**
      * Array of attributes to getter functions (for serialization of requests)
      * @var string[]
      */
    static $getters = array(
        'table_row_list' => 'getTableRowList',
        'table_properties' => 'getTableProperties',
        'node_id' => 'getNodeId',
        'link' => 'getLink'
    );
  
    
    /**
      * $table_row_list 
      * @var \Swagger\Client\Model\TableRow[]
      */
    protected $table_row_list;
    
    /**
      * $table_properties 
      * @var \Swagger\Client\Model\TableProperties
      */
    protected $table_properties;
    
    /**
      * $node_id 
      * @var string
      */
    protected $node_id;
    
    /**
      * $link 
      * @var \Swagger\Client\Model\Link
      */
    protected $link;
    

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        if ($data != null) {
            $this->table_row_list = $data["table_row_list"];
            $this->table_properties = $data["table_properties"];
            $this->node_id = $data["node_id"];
            $this->link = $data["link"];
        }
    }
    
    /**
     * Gets table_row_list
     * @return \Swagger\Client\Model\TableRow[]
     */
    public function getTableRowList()
    {
        return $this->table_row_list;
    }
  
    /**
     * Sets table_row_list
     * @param \Swagger\Client\Model\TableRow[] $table_row_list 
     * @return $this
     */
    public function setTableRowList($table_row_list)
    {
        
        $this->table_row_list = $table_row_list;
        return $this;
    }
    
    /**
     * Gets table_properties
     * @return \Swagger\Client\Model\TableProperties
     */
    public function getTableProperties()
    {
        return $this->table_properties;
    }
  
    /**
     * Sets table_properties
     * @param \Swagger\Client\Model\TableProperties $table_properties 
     * @return $this
     */
    public function setTableProperties($table_properties)
    {
        
        $this->table_properties = $table_properties;
        return $this;
    }
    
    /**
     * Gets node_id
     * @return string
     */
    public function getNodeId()
    {
        return $this->node_id;
    }
  
    /**
     * Sets node_id
     * @param string $node_id 
     * @return $this
     */
    public function setNodeId($node_id)
    {
        
        $this->node_id = $node_id;
        return $this;
    }
    
    /**
     * Gets link
     * @return \Swagger\Client\Model\Link
     */
    public function getLink()
    {
        return $this->link;
    }
  
    /**
     * Sets link
     * @param \Swagger\Client\Model\Link $link 
     * @return $this
     */
    public function setLink($link)
    {
        
        $this->link = $link;
        return $this;
    }
    
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset 
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->$offset);
    }
  
    /**
     * Gets offset.
     * @param  integer $offset Offset 
     * @return mixed 
     */
    public function offsetGet($offset)
    {
        return $this->$offset;
    }
  
    /**
     * Sets value based on offset.
     * @param  integer $offset Offset 
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        $this->$offset = $value;
    }
  
    /**
     * Unsets offset.
     * @param  integer $offset Offset 
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->$offset);
    }
  
    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) {
            return json_encode(get_object_vars($this), JSON_PRETTY_PRINT);
        } else {
            return json_encode(get_object_vars($this));
        }
    }
}
