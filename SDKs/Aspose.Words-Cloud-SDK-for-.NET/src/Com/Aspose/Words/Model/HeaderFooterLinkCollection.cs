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
  /// Collection of links to header/footers
  /// </summary>  
  public class HeaderFooterLinkCollection 
  {                       
        /// <summary>
        /// Collection of section's links
        /// </summary>
        /// <value>Collection of section's links</value>    
        public List<HeaderFooterLink> List { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HeaderFooterLinkCollection {\n");
          sb.Append("  List: ").Append(List).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
