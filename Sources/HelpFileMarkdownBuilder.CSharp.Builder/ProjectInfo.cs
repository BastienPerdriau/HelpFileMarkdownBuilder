using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Project informations
    /// </summary>
    public class ProjectInfo
    {
        /// <summary>
        /// Project file path
        /// </summary>
        public string ProjectFilePath { get; set; }

        /// <summary>
        /// Assembly name
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Build configurations
        /// </summary>
        public Dictionary<string, BuildConfiguration> BuildConfigurations = new Dictionary<string, BuildConfiguration>();
    }
}
