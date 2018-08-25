using System.Collections.Generic;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile
{
    /// <summary>
    /// Root of a documentation file
    /// </summary>
    [XmlRoot("doc")]
    public class XmlDoc
    {
        /// <summary>
        /// Assembly
        /// </summary>
        [XmlElement("assembly")]
        public XmlAssembly Assembly { get; set; } = null;

        /// <summary>
        /// Members
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("member")]
        public List<XmlMember> Members = new List<XmlMember>();
    }
}
