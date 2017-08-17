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
  public class FormFieldDropDown : FormField 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldDropDown" /> class.
        /// </summary>
        /// <param name="NodeId">NodeId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="StatusText">StatusText.</param>
        /// <param name="OwnStatus">OwnStatus.</param>
        /// <param name="HelpText">HelpText.</param>
        /// <param name="OwnHelp">OwnHelp.</param>
        /// <param name="CalculateOnExit">CalculateOnExit.</param>
        /// <param name="EntryMacro">EntryMacro.</param>
        /// <param name="ExitMacro">ExitMacro.</param>
        /// <param name="FormFieldType">FormFieldType.</param>
        /// <param name="Link">Link.</param>
        /// <param name="DropDownSelectedIndex">DropDownSelectedIndex.</param>
        /// <param name="DropDownItems">DropDownItems.</param>
        public FormFieldDropDown(string NodeId = default(string), string Name = default(string), bool? Enabled = default(bool?), string StatusText = default(string), bool? OwnStatus = default(bool?), string HelpText = default(string), bool? OwnHelp = default(bool?), bool? CalculateOnExit = default(bool?), string EntryMacro = default(string), string ExitMacro = default(string), string FormFieldType = default(string), WordsApiLink Link = default(WordsApiLink), int? DropDownSelectedIndex = default(int?), List<string> DropDownItems = default(List<string>))
        {
                        this.NodeId = NodeId;
                        this.Name = Name;
                        this.Enabled = Enabled;
                        this.StatusText = StatusText;
                        this.OwnStatus = OwnStatus;
                        this.HelpText = HelpText;
                        this.OwnHelp = OwnHelp;
                        this.CalculateOnExit = CalculateOnExit;
                        this.EntryMacro = EntryMacro;
                        this.ExitMacro = ExitMacro;
                        this.FormFieldType = FormFieldType;
                        this.Link = Link;
                        this.DropDownSelectedIndex = DropDownSelectedIndex;
                        this.DropDownItems = DropDownItems;
        }

        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>    
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled
        /// </summary>    
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets StatusText
        /// </summary>    
        public string StatusText { get; set; }

        /// <summary>
        /// Gets or sets OwnStatus
        /// </summary>    
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Gets or sets HelpText
        /// </summary>    
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets OwnHelp
        /// </summary>    
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// Gets or sets CalculateOnExit
        /// </summary>    
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Gets or sets EntryMacro
        /// </summary>    
        public string EntryMacro { get; set; }

        /// <summary>
        /// Gets or sets ExitMacro
        /// </summary>    
        public string ExitMacro { get; set; }

        /// <summary>
        /// Gets or sets FormFieldType
        /// </summary>    
        public string FormFieldType { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Gets or sets DropDownSelectedIndex
        /// </summary>    
        public int? DropDownSelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets DropDownItems
        /// </summary>    
        public List<string> DropDownItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldDropDown {\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  StatusText: ").Append(StatusText).Append("\n");
          sb.Append("  OwnStatus: ").Append(OwnStatus).Append("\n");
          sb.Append("  HelpText: ").Append(HelpText).Append("\n");
          sb.Append("  OwnHelp: ").Append(OwnHelp).Append("\n");
          sb.Append("  CalculateOnExit: ").Append(CalculateOnExit).Append("\n");
          sb.Append("  EntryMacro: ").Append(EntryMacro).Append("\n");
          sb.Append("  ExitMacro: ").Append(ExitMacro).Append("\n");
          sb.Append("  FormFieldType: ").Append(FormFieldType).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("  DropDownSelectedIndex: ").Append(DropDownSelectedIndex).Append("\n");
          sb.Append("  DropDownItems: ").Append(DropDownItems).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
