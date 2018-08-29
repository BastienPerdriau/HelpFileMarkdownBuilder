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
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSInterface ToMarkdown
            return null;
        }
    }
}
