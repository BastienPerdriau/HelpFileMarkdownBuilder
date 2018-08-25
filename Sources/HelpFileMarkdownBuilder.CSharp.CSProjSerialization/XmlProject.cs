using System.Collections.Generic;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.CSProjSerialization
{
    /// <summary>
    /// Root of a proj file
    /// </summary>
    [XmlRoot("Project", Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
    public class XmlProject
    {
        /// <summary>
        /// PropertyGroup nodes
        /// </summary>
        [XmlElement("PropertyGroup")]
        public List<XmlPropertyGroup> PropertyGroups { get; set; } = new List<XmlPropertyGroup>();
    }
}
