using System.Reflection;
using System.Text.RegularExpressions;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Assembly
    /// </summary>
    public class CSAssembly : CSTypeSubset
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Assembly";

        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Assemblies";

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Name}.{SingleMemberTypeName}.md";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="assembly">C-Sharp assembly</param>
        public CSAssembly(Assembly assembly)
        {
            Name = Regex.Match(assembly.FullName, @"^(?'name'.*?),", RegexOptions.IgnoreCase).Groups["name"].Value;
        }

        /// <summary>
        /// Gets the Markdown content for the current assembly
        /// </summary>
        /// <returns>Markdown content for the current assembly</returns>
        public override string ToMarkdown()
        {
            // TODO CSAssembly ToMarkdown
            return string.Empty;
        }
    }
}
