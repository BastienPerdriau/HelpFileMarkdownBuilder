using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.XmlDocSerialization
{
    /// <summary>
    /// Documentation about the name of an assembly
    /// </summary>
    [XmlType("name")]
    public class XmlAssemblyName
    {
        /// <summary>
        /// Value of the name
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
