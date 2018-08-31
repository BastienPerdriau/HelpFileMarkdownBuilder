using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of types
    /// </summary>
    public class CSTypeCollection : CSMemberCollection<CSType>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Types";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSTypeCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSTypeCollection(IEnumerable<CSType> members) : base(members) { }
    }
}
