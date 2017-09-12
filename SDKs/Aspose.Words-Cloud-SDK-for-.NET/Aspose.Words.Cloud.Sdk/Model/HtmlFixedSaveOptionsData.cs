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
  /// container class for fixed html save options
  /// </summary>  
  public class HtmlFixedSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies prefix which is added to all class names in style.css file.  Default value is \"aw\".
        /// </summary>  
        public string CssClassNamesPrefix { get; set; }

        /// <summary>
        /// Specifies whether the CSS (Cascading Style Sheet) should be embedded into Html document.
        /// </summary>  
        public bool? ExportEmbeddedCss { get; set; }

        /// <summary>
        /// Specifies whether fonts should be embedded into Html document in Base64 format.
        /// </summary>  
        public bool? ExportEmbeddedFonts { get; set; }

        /// <summary>
        /// Specifies whether images should be embedded into Html document in Base64 format.
        /// </summary>  
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets indication of whether form fields are exported as interactive items (as 'input' tag) rather than converted to text or graphics.
        /// </summary>  
        public bool? ExportFormFields { get; set; }

        /// <summary>
        /// Encoding.
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Specifies export format of fonts
        /// </summary>  
        public string FontFormat { get; set; }

        /// <summary>
        /// Specifies the physical folder where resources are saved when exporting a document
        /// </summary>  
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct resource URIs
        /// </summary>  
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Specifies whether border around pages should be shown.
        /// </summary>  
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Specifies the horizontal alignment of pages in an HTML document.  Default value is HtmlFixedHorizontalPageAlignment.Center.
        /// </summary>  
        public string PageHorizontalAlignment { get; set; }

        /// <summary>
        /// Specifies the margins around pages in an HTML document.  The margins value is measured in points and should be equal to or greater than 0.  Default value is 10 points.
        /// </summary>  
        public double? PageMargins { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlFixedSaveOptionsData {\n");
          sb.Append("  CssClassNamesPrefix: ").Append(this.CssClassNamesPrefix).Append("\n");
          sb.Append("  ExportEmbeddedCss: ").Append(this.ExportEmbeddedCss).Append("\n");
          sb.Append("  ExportEmbeddedFonts: ").Append(this.ExportEmbeddedFonts).Append("\n");
          sb.Append("  ExportEmbeddedImages: ").Append(this.ExportEmbeddedImages).Append("\n");
          sb.Append("  ExportFormFields: ").Append(this.ExportFormFields).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  FontFormat: ").Append(this.FontFormat).Append("\n");
          sb.Append("  ResourcesFolder: ").Append(this.ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(this.ResourcesFolderAlias).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
          sb.Append("  PageHorizontalAlignment: ").Append(this.PageHorizontalAlignment).Append("\n");
          sb.Append("  PageMargins: ").Append(this.PageMargins).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
