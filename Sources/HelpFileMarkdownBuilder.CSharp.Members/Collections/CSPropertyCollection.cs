using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of properties
    /// </summary>
    public class CSPropertyCollection : CSMemberCollection<CSProperty>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Properties";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSPropertyCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSPropertyCollection(IEnumerable<CSProperty> members) : base(members) { }
    }
}
