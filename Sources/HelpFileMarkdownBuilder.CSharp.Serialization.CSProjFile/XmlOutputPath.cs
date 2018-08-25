using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
{
    /// <summary>
    /// OutputPath node
    /// </summary>
    [XmlType("OutputPath")]
    public class XmlOutputPath
    {
        /// <summary>
        /// Value of the OutputPath node
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
