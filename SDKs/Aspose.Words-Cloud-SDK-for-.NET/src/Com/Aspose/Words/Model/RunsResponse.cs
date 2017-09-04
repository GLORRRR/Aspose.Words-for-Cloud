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
  public class RunsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Runs
        /// </summary>    
        public RunsDto Runs { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RunsResponse {\n");
          sb.Append("  Runs: ").Append(Runs).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
