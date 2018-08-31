using HelpFileMarkdownBuilder.Base;
using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of CSMembers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CSMemberCollection<T> : MemberCollection<T> where T : CSMember
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSMemberCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSMemberCollection(IEnumerable<T> members) : base(members) { }
    }
}
