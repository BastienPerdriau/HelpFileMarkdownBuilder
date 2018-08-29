using HelpFileMarkdownBuilder.CSharp.Members;
using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Class to read assemblies to get members
    /// </summary>
    internal class CSharpAssemblyReader
    {
        /// <summary>
        /// List of project infos
        /// </summary>
        public List<ProjectInfo> ProjectInfos { get; internal set; }

        /// <summary>
        /// List of C-Sharp members
        /// </summary>
        public CSMemberCollection CSMembers { get; } = new CSMemberCollection();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="projectInfos">List of project infos</param>
        public CSharpAssemblyReader(List<ProjectInfo> projectInfos)
        {
            ProjectInfos = projectInfos;
        }


    }
}
