using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of strong types
    /// </summary>
    public class CSStrongTypeCollection : CSMemberCollection<CSStrongType>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Strong types";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSStrongTypeCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSStrongTypeCollection(IEnumerable<CSStrongType> members) : base(members) { }
    }
}
