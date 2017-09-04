using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class OfficeMathObjectResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets OfficeMathObject
        /// </summary>    
        public OfficeMathObjectDto OfficeMathObject { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OfficeMathObjectResponse {\n");
          sb.Append("  OfficeMathObject: ").Append(OfficeMathObject).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
