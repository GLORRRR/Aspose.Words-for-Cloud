using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class SectionLinkCollection {
    public List<SectionLink> SectionLinkList { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SectionLinkCollection {\n");
      sb.Append("  SectionLinkList: ").Append(SectionLinkList).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
