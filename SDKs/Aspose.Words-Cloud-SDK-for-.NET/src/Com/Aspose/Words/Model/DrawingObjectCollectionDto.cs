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
  public class DrawingObjectCollectionDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawingObjectCollectionDto" /> class.
        /// </summary>
        /// <param name="List">List.</param>
        /// <param name="Link">Link.</param>
        public DrawingObjectCollectionDto(List<LinkElement> List = default(List<LinkElement>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.List = List;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets List
        /// </summary>    
        public List<LinkElement> List { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObjectCollectionDto {\n");
          sb.Append("  List: ").Append(List).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
