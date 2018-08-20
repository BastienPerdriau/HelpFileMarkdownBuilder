using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization
{
    /// <summary>
    /// Documentation about a typeparam
    /// </summary>
    [XmlType("typeparam")]
    public class XmlTypeParam
    {
        /// <summary>
        /// Name of the typeparam
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Value of the typeparam
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
