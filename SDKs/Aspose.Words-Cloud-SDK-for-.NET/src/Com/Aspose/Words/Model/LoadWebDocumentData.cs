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
  public class LoadWebDocumentData 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadWebDocumentData" /> class.
        /// </summary>
        /// <param name="LoadingDocumentUrl">LoadingDocumentUrl.</param>
        /// <param name="SaveOptions">SaveOptions.</param>
        public LoadWebDocumentData(string LoadingDocumentUrl = default(string), SaveOptionsData SaveOptions = default(SaveOptionsData))
        {
                        this.LoadingDocumentUrl = LoadingDocumentUrl;
                        this.SaveOptions = SaveOptions;
        }

        /// <summary>
        /// Gets or sets LoadingDocumentUrl
        /// </summary>    
        public string LoadingDocumentUrl { get; set; }

        /// <summary>
        /// Gets or sets SaveOptions
        /// </summary>    
        public SaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LoadWebDocumentData {\n");
          sb.Append("  LoadingDocumentUrl: ").Append(LoadingDocumentUrl).Append("\n");
          sb.Append("  SaveOptions: ").Append(SaveOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
