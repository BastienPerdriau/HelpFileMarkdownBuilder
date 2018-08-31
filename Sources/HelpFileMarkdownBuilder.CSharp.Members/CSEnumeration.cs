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
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Enumeration";

        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Enumeration";

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Namespace.Name}.{Name}.{SingleMemberTypeName}.md";

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
        /// Gets the Markdown content for the current enumeration
        /// </summary>
        /// <returns>Markdown content for the current enumeration</returns>
        public override string ToMarkdown()
        {
            // TODO CSEnumeration ToMarkdown
            return string.Empty;
        }
    }
}
