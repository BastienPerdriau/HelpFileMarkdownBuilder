using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of methods
    /// </summary>
    public class CSMethodCollection : CSMemberCollection<CSMethod>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Methods";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSMethodCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSMethodCollection(IEnumerable<CSMethod> members) : base(members) { }
    }
}
