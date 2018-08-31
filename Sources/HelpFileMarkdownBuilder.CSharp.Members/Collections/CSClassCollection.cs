using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of classes
    /// </summary>
    public class CSClassCollection : CSMemberCollection<CSClass>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Classes";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSClassCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSClassCollection(IEnumerable<CSClass> members) : base(members) { }
    }
}
