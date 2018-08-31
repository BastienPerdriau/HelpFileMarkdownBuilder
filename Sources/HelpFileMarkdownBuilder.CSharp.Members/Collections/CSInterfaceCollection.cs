using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of interfaces
    /// </summary>
    public class CSInterfaceCollection : CSMemberCollection<CSInterface>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Interfaces";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSInterfaceCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSInterfaceCollection(IEnumerable<CSInterface> members) : base(members) { }
    }
}
