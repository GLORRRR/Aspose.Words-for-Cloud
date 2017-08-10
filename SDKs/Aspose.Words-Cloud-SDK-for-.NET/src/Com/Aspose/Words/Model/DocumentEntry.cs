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
  public class DocumentEntry {
    
    /// <summary>
    /// Gets or Sets Href
    /// </summary>    
    public string Href { get; set; }

    
    /// <summary>
    /// Gets or Sets ImportFormatMode
    /// </summary>    
    public string ImportFormatMode { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentEntry {\n");
      
      sb.Append("  Href: ").Append(Href).Append("\n");
      
      sb.Append("  ImportFormatMode: ").Append(ImportFormatMode).Append("\n");
      
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
