using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# String type (class or interface)
    /// </summary>
    public abstract class CSStrongType : CSType
    {
        // TODO Public / Internal

        /// <summary>
        /// Members
        /// </summary>
        public List<CSStrongTypeMember> Members { get; set; } = new List<CSStrongTypeMember>();

        /// <summary>
        /// Properties
        /// </summary>
        public List<CSProperty> Properties => Members.OfType<CSProperty>().ToList();

        /// <summary>
        /// Methods
        /// </summary>
        public List<CSMethod> Methods => Members.OfType<CSMethod>().ToList();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSStrongType(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type) { }
    }
}
