using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of namespaces
    /// </summary>
    public class CSNamespaceCollection : CSMemberCollection<CSNamespace>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Namespaces";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSNamespaceCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSNamespaceCollection(IEnumerable<CSNamespace> members) : base(members) { }
    }
}
