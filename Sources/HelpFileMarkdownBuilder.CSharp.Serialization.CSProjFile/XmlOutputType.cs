using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
{
    /// <summary>
    /// OutputType node
    /// </summary>
    [XmlType("OutputType")]
    public class XmlOutputType
    {
        /// <summary>
        /// Value of the OutputType node
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
