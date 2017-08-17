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
  public class Bookmark 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmark" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Link">Link.</param>
        public Bookmark(string Name = default(string), string Text = default(string), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Name = Name;
                        this.Text = Text;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>    
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>    
        public string Text { get; set; }

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
          sb.Append("class Bookmark {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
