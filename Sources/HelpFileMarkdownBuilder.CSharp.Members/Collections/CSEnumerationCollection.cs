using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of enumerations
    /// </summary>
    public class CSEnumerationCollection : CSMemberCollection<CSEnumeration>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Enumerations";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSEnumerationCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSEnumerationCollection(IEnumerable<CSEnumeration> members) : base(members) { }
    }
}
