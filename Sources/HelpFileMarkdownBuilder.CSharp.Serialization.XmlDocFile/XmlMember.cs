using System.Collections.Generic;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile
{
    /// <summary>
    /// Documentation about a member
    /// </summary>
    [XmlType("member")]
    public class XmlMember
    {
        /// <summary>
        /// Name of the param
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Summary of the member
        /// </summary>
        [XmlElement("summary")]
        public XmlMemberSummary Summary { get; set; } = null;

        /// <summary>
        /// Typeparam of the member
        /// </summary>
        [XmlElement("typeparam")]
        public XmlTypeParam TypeParam { get; set; } = null;

        /// <summary>
        /// Params of the member
        /// </summary>
        [XmlElement("param")]
        public List<XmlParam> Params { get; set; } = new List<XmlParam>();
    }
}
