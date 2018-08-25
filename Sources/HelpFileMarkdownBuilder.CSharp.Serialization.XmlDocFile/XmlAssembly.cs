using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile
{
    /// <summary>
    /// Documentation about an assembly
    /// </summary>
    [XmlType("assembly")]
    public class XmlAssembly
    {
        /// <summary>
        /// Name of the assembly
        /// </summary>
        [XmlElement("name")]
        public XmlAssemblyName Name { get; set; } = null;
    }
}
