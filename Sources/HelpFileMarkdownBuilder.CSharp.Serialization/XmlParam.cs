using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization
{
    /// <summary>
    /// Documentation about a param
    /// </summary>
    [XmlType("param")]
    public class XmlParam
    {
        /// <summary>
        /// Name of the param
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Value of the param
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
