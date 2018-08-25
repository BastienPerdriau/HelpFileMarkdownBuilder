using HelpFileMarkdownBuilder.Base;
using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// C# Enumeration
    /// </summary>
    public class CSEnumeration : CSType
    {
        /// <summary>
        /// List of values
        /// </summary>
        public List<CSEnumerationValue> Values { get; set; } = new List<CSEnumerationValue>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        public CSEnumeration(CSAssembly csAssembly, CSNamespace csNamespace) : base(csAssembly, csNamespace) { }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSEnumeration ToMarkdown
            return null;
        }
    }
}
