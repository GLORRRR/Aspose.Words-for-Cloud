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
  /// Represents all formatting for a table row.
  /// </summary>  
  public class TableCellFormat 
  {                       
        /// <summary>
        /// Specifies how the cell is merged horizontally with other cells in the row.
        /// </summary>
        /// <value>Specifies how the cell is merged horizontally with other cells in the row.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalMergeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous
        }

        /// <summary>
        /// Returns or sets the orientation of text in a table cell.
        /// </summary>
        /// <value>Returns or sets the orientation of text in a table cell.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>            
            Horizontal,
            
            /// <summary>
            /// Enum Downward for "Downward"
            /// </summary>            
            Downward,
            
            /// <summary>
            /// Enum Upward for "Upward"
            /// </summary>            
            Upward,
            
            /// <summary>
            /// Enum HorizontalRotatedFarEast for "HorizontalRotatedFarEast"
            /// </summary>            
            HorizontalRotatedFarEast,
            
            /// <summary>
            /// Enum VerticalFarEast for "VerticalFarEast"
            /// </summary>            
            VerticalFarEast,
            
            /// <summary>
            /// Enum VerticalRotatedFarEast for "VerticalRotatedFarEast"
            /// </summary>            
            VerticalRotatedFarEast
        }

        /// <summary>
        /// Returns or sets the vertical alignment of text in the cell.
        /// </summary>
        /// <value>Returns or sets the vertical alignment of text in the cell.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        {
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom
        }

        /// <summary>
        /// Specifies how the cell is merged with other cells vertically.
        /// </summary>
        /// <value>Specifies how the cell is merged with other cells vertically.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalMergeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous
        }

        /// <summary>
        /// Specifies how the cell is merged horizontally with other cells in the row.
        /// </summary>
        /// <value>Specifies how the cell is merged horizontally with other cells in the row.</value>
        public HorizontalMergeEnum? HorizontalMerge { get; set; }

        /// <summary>
        /// Returns or sets the orientation of text in a table cell.
        /// </summary>
        /// <value>Returns or sets the orientation of text in a table cell.</value>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Returns or sets the vertical alignment of text in the cell.
        /// </summary>
        /// <value>Returns or sets the vertical alignment of text in the cell.</value>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Specifies how the cell is merged with other cells vertically.
        /// </summary>
        /// <value>Specifies how the cell is merged with other cells vertically.</value>
        public VerticalMergeEnum? VerticalMerge { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add below the contents of cell.
        /// </summary>  
        public double? BottomPadding { get; set; }

        /// <summary>
        /// If true, fits text in the cell, compressing each paragraph to the width of the cell.
        /// </summary>  
        public bool? FitText { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add to the left of the contents of cell.
        /// </summary>  
        public double? LeftPadding { get; set; }

        /// <summary>
        /// Returns or sets the preferred width of the cell.
        /// </summary>  
        public PreferredWidth PreferredWidth { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add to the right of the contents of cell.
        /// </summary>  
        public double? RightPadding { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add above the contents of cell.
        /// </summary>  
        public double? TopPadding { get; set; }

        /// <summary>
        /// Gets the width of the cell in points.
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// If true, wrap text for the cell.
        /// </summary>  
        public bool? WrapText { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellFormat {\n");
          sb.Append("  BottomPadding: ").Append(this.BottomPadding).Append("\n");
          sb.Append("  FitText: ").Append(this.FitText).Append("\n");
          sb.Append("  HorizontalMerge: ").Append(this.HorizontalMerge).Append("\n");
          sb.Append("  LeftPadding: ").Append(this.LeftPadding).Append("\n");
          sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
          sb.Append("  PreferredWidth: ").Append(this.PreferredWidth).Append("\n");
          sb.Append("  RightPadding: ").Append(this.RightPadding).Append("\n");
          sb.Append("  TopPadding: ").Append(this.TopPadding).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
          sb.Append("  VerticalMerge: ").Append(this.VerticalMerge).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  WrapText: ").Append(this.WrapText).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
