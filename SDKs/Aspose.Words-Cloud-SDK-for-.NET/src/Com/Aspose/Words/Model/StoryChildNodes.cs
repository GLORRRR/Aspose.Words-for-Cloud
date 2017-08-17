using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class StoryChildNodes {
    /// <summary>
    /// Gets or Sets ChildNodes
    /// </summary>    
    public List<NodeLink> ChildNodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class StoryChildNodes {\n");
      sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
