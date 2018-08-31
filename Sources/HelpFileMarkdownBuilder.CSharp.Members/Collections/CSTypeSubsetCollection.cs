using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of type subsets
    /// </summary>
    public class CSTypeSubsetCollection : CSMemberCollection<CSTypeSubset>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Type subsets";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSTypeSubsetCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSTypeSubsetCollection(IEnumerable<CSTypeSubset> members) : base(members) { }
    }
}
