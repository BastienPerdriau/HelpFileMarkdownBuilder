using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of strong type members
    /// </summary>
    public class CSStrongTypeMemberCollection : CSMemberCollection<CSStrongTypeMember>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Strong type members";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSStrongTypeMemberCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSStrongTypeMemberCollection(IEnumerable<CSStrongTypeMember> members) : base(members) { }
    }
}
