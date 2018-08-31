using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Namespace
    /// </summary>
    public class CSNamespace : CSTypeSubset
    {
        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Name}.Namespace.md";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        public CSNamespace(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the Markdown content for the current namespace
        /// </summary>
        /// <returns>Markdown content for the current namespace</returns>
        public override string ToMarkdown()
        {
            // TODO CSNamespace ToMarkdown
            return string.Empty;
        }
    }
}
