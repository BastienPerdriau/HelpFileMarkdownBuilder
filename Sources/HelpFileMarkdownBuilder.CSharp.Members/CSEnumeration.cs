using HelpFileMarkdownBuilder.Base;
using System.Collections.Generic;
using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Members
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
        /// <param name="type">Type</param>
        public CSEnumeration(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type)
        {
            // TODO CSEnumeration constructor
        }

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
