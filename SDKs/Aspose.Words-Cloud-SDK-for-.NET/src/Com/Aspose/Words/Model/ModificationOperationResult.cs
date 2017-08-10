using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace Com.Aspose.Words.Model {

  /// <summary>
  /// 
  /// </summary>  
  public class ModificationOperationResult {
    
    /// <summary>
    /// Gets or Sets Source
    /// </summary>    
    public FileLink Source { get; set; }

    
    /// <summary>
    /// Gets or Sets Dest
    /// </summary>    
    public FileLink Dest { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModificationOperationResult {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Dest: ").Append(Dest).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}
