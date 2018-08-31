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
        public CSStrongTypeMemberCollection Members { get; set; } = new CSStrongTypeMemberCollection();

        /// <summary>
        /// Properties
        /// </summary>
        public CSPropertyCollection Properties => new CSPropertyCollection(Members.OfType<CSProperty>());

        /// <summary>
        /// Methods
        /// </summary>
        public CSMethodCollection Methods => new CSMethodCollection(Members.OfType<CSMethod>());

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSStrongType(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type) { }
    }
}
