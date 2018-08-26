using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
{
    /// <summary>
    /// Root of a proj file
    /// </summary>
    [XmlRoot("Project", Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
    public class XmlProject
    {
        /// <summary>
        /// Project file path
        /// </summary>
        [XmlIgnore]
        public string ProjectFilePath { get; set; }

        /// <summary>
        /// PropertyGroup nodes
        /// </summary>
        [XmlElement("PropertyGroup")]
        public List<XmlPropertyGroup> PropertyGroups { get; set; } = new List<XmlPropertyGroup>();

        /// <summary>
        /// Gets the general property group
        /// </summary>
        [XmlIgnore]
        public XmlPropertyGroup GeneralPropertyGroup => PropertyGroups.FirstOrDefault(g => string.IsNullOrWhiteSpace(g.Condition));

        /// <summary>
        /// Gets the property groups with build configuration
        /// </summary>
        [XmlIgnore]
        public List<XmlPropertyGroup> BuildConfigurationPropertyGroups => PropertyGroups.Where(g => !string.IsNullOrWhiteSpace(g.Condition)).ToList();
    }
}
