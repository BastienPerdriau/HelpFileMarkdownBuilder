using HelpFileMarkdownBuilder.Base;
using System.Collections.Generic;
using System.Linq;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of C-Sharp members
    /// </summary>
    public class CSMemberCollection : List<CSMember>
    {
        /// <summary>
        /// Gets the namespaces from the C-Sharp members collection
        /// </summary>
        public List<CSNamespace> Namespaces => this.OfType<CSNamespace>().ToList();

        /// <summary>
        /// Gets the assemblies from the C-Sharp members collection
        /// </summary>
        public List<CSAssembly> Assemblies => this.OfType<CSAssembly>().ToList();

        /// <summary>
        /// Gets the types from the C-Sharp members collection
        /// </summary>
        public List<CSType> Types => this.OfType<CSType>().ToList();

        /// <summary>
        /// Gets the classes from the C-Sharp members collection
        /// </summary>
        public List<CSClass> Classes => this.OfType<CSClass>().ToList();

        /// <summary>
        /// Gets the interfaces from the C-Sharp members collection
        /// </summary>
        public List<CSInterface> Interfaces => this.OfType<CSInterface>().ToList();

        /// <summary>
        /// Gets the enumerations from the C-Sharp members collection
        /// </summary>
        public List<CSEnumeration> Enumerations => this.OfType<CSEnumeration>().ToList();

        /// <summary>
        /// Gets a summary of documented namespaces
        /// </summary>
        /// <returns>Summary of documented namespaces</returns>
        public HelpFile GetHelpFileSummary()
        {
            HelpFile summary = new HelpFile();
            
            // TODO Make summary

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
            helpFiles.AddRange(this.Select(m => m.ToMarkdown()).ToList());

            return helpFiles;
        }
    }
}
