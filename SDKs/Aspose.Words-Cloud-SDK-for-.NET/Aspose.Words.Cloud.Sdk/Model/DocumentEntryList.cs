namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  public class DocumentEntryList 
  {                       
        /// <summary>
        /// Gets or sets DocumentEntries
        /// </summary>  
        public List<DocumentEntry> DocumentEntries { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentEntryList {\n");
          sb.Append("  DocumentEntries: ").Append(this.DocumentEntries).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
