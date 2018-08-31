using HelpFileMarkdownBuilder.Base;
using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Interface
    /// </summary>
    public class CSInterface : CSStrongType
    {
        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Namespace.Name}.{Name}.Interface.md";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSInterface(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type)
        {
            // TODO CSInterface constructor
        }

        /// <summary>
        /// Gets the Markdown content for the current interface
        /// </summary>
        /// <returns>Markdown content for the current interface</returns>
        public override string ToMarkdown()
        {
            // TODO CSInterface ToMarkdown
            return string.Empty;
        }
    }
}
