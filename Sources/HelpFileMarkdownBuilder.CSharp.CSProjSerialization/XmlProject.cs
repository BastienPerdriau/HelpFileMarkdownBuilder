using System.Collections.Generic;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.CSProjSerialization
{
    /// <summary>
    /// Root of a proj file
    /// </summary>
    [XmlRoot("Project")]
    public class XmlProject
    {
        /// <summary>
        /// PropertyGroup nodes
        /// </summary>
        [XmlArrayItem("PropertyGroup")]
        public List<XmlPropertyGroup> PropertyGroups = new List<XmlPropertyGroup>();
    }
}
