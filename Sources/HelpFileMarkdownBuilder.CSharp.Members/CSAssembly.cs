using HelpFileMarkdownBuilder.Base;
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
        /// Constructor
        /// </summary>
        /// <param name="assembly">C-Sharp assembly</param>
        public CSAssembly(Assembly assembly)
        {
            Name = Regex.Match(assembly.FullName, @"^(?'name'.*?),", RegexOptions.IgnoreCase).Groups["name"].Value;
        }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSAssembly ToMarkdown
            return null;
        }
    }
}
