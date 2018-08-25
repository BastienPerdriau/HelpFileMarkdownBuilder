using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
{
    /// <summary>
    /// AssemblyName node
    /// </summary>
    [XmlType("AssemblyName")]
    public class XmlAssemblyName
    {
        /// <summary>
        /// Value of the AssemblyName node
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
