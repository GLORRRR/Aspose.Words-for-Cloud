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
  public class DocumentEntryList 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentEntryList" /> class.
        /// </summary>
        /// <param name="DocumentEntries">DocumentEntries.</param>
        public DocumentEntryList(List<DocumentEntry> DocumentEntries = default(List<DocumentEntry>))
        {
                        this.DocumentEntries = DocumentEntries;
        }

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
          sb.Append("  DocumentEntries: ").Append(DocumentEntries).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
