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
        /// Member file name
        /// </summary>
        public override string FileName => $"{Name}.{SingleMemberTypeName}.md";

        /// <summary>
        /// ConstructoR
        /// </summary>
        /// <param name="assembly">C-Sharp assembly</param>
        public CSAssembly(Assembly assembly)
        {
            Name = Regex.Match(assembly.FullName, @"^(?'name'.*?),", RegexOptions.IgnoreCase).Groups["name"].Value;
        }
    }
}
