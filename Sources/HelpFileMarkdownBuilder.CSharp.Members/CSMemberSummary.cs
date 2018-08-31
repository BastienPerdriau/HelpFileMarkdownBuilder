using HelpFileMarkdownBuilder.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Summary of C-Sharp members
    /// </summary>
    public class CSMemberSummary : CSMemberCollection<CSMember>
    {
        /// <summary>
        /// API name
        /// </summary>
        public string ApiName { get; set; } = string.Empty;

        /// <summary>
        /// API version
        /// </summary>
        public string ApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// Date of building doc
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Gets the namespaces from the C-Sharp members collection
        /// </summary>
        public CSNamespaceCollection Namespaces => new CSNamespaceCollection(this.OfType<CSNamespace>());

        /// <summary>
        /// Gets the assemblies from the C-Sharp members collection
        /// </summary>
        public CSAssemblyCollection Assemblies => new CSAssemblyCollection(this.OfType<CSAssembly>());

        /// <summary>
        /// Gets the types from the C-Sharp members collection
        /// </summary>
        public CSTypeCollection Types => new CSTypeCollection(this.OfType<CSType>());

        /// <summary>
        /// Gets the classes from the C-Sharp members collection
        /// </summary>
        public CSClassCollection Classes => new CSClassCollection(this.OfType<CSClass>());

        /// <summary>
        /// Gets the interfaces from the C-Sharp members collection
        /// </summary>
        public CSInterfaceCollection Interfaces => new CSInterfaceCollection(this.OfType<CSInterface>());

        /// <summary>
        /// Gets the enumerations from the C-Sharp members collection
        /// </summary>
        public CSEnumerationCollection Enumerations => new CSEnumerationCollection(this.OfType<CSEnumeration>());

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSMemberSummary() : base() { }

        /// <summary>
        /// Gets a summary of documented namespaces
        /// </summary>
        /// <returns>Summary of documented namespaces</returns>
        public HelpFile GetHelpFileSummary()
        {
            HelpFile summary = new HelpFile()
            {
                Name = $"{ApiName}.{ApiVersion}.Summary.md"
            };

            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"# {ApiName}");
            builder.AppendLine($"#### Version {ApiVersion}");
            builder.AppendLine($"#### Update date {UpdateDate.ToString("dd-MM-yyyy")}");
            builder.AppendLine();
            builder.Append(Namespaces.GetCoreListView(false));

            summary.Content = builder.ToString();

            return summary;
        }

        /// <summary>
        /// Gets the help files from the C-Sharp members collection
        /// </summary>
        /// <returns>Help files from the C-Sharp members collection</returns>
        public List<HelpFile> GetHelpFiles()
        {
            List<HelpFile> helpFiles = new List<HelpFile>();

            helpFiles.Add(GetHelpFileSummary());
            helpFiles.AddRange(this.Select(m => m.ToHelpFile()).ToList());

            return helpFiles;
        }
    }
}
