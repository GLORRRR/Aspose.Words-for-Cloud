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
  public class TableRowDto 
  {                       
        /// <summary>
        /// Gets or sets TableCellList
        /// </summary>    
        public List<TableCellDto> TableCellList { get; set; }

        /// <summary>
        /// Gets or sets RowFormat
        /// </summary>    
        public TableRowFormatDto RowFormat { get; set; }

        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

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
          sb.Append("class TableRowDto {\n");
          sb.Append("  TableCellList: ").Append(TableCellList).Append("\n");
          sb.Append("  RowFormat: ").Append(RowFormat).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
