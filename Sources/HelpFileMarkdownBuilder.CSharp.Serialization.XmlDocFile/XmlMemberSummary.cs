using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile
{
    /// <summary>
    /// Documentation about the summary of a member
    /// </summary>
    [XmlType("summary")]
    public class XmlMemberSummary
    {
        /// <summary>
        /// Value of the summary
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
