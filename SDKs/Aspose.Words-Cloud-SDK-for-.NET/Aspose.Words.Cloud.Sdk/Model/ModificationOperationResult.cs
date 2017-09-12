namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// result of the operation which modifies the original document and saves the result
  /// </summary>  
  public class ModificationOperationResult 
  {                       
        /// <summary>
        /// Link to the source document (source for the modification operation)
        /// </summary>  
        public FileLink Source { get; set; }

        /// <summary>
        /// Link to the dest document (result of the modification operation)
        /// </summary>  
        public FileLink Dest { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ModificationOperationResult {\n");
          sb.Append("  Source: ").Append(this.Source).Append("\n");
          sb.Append("  Dest: ").Append(this.Dest).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
