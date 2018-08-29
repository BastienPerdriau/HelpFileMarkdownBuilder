using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Namespace
    /// </summary>
    public class CSNamespace : CSTypeSubset
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        public CSNamespace(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSNamespace ToMarkdown
            return null;
        }
    }
}
