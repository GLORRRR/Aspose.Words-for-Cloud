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
  public class PageStatData 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="PageStatData" /> class.
        /// </summary>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="WordCount">WordCount.</param>
        /// <param name="ParagraphCount">ParagraphCount.</param>
        /// <param name="FootnotesStatData">FootnotesStatData.</param>
        public PageStatData(int? PageNumber = default(int?), int? WordCount = default(int?), int? ParagraphCount = default(int?), FootnotesStatData FootnotesStatData = default(FootnotesStatData))
        {
                        this.PageNumber = PageNumber;
                        this.WordCount = WordCount;
                        this.ParagraphCount = ParagraphCount;
                        this.FootnotesStatData = FootnotesStatData;
        }

        /// <summary>
        /// Gets or sets PageNumber
        /// </summary>    
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets WordCount
        /// </summary>    
        public int? WordCount { get; set; }

        /// <summary>
        /// Gets or sets ParagraphCount
        /// </summary>    
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Gets or sets FootnotesStatData
        /// </summary>    
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageStatData {\n");
          sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
          sb.Append("  WordCount: ").Append(WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
          sb.Append("  FootnotesStatData: ").Append(FootnotesStatData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
