using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of structs
    /// </summary>
    public class CSStructCollection :  CSMemberCollection<CSStruct>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Structs";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSStructCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSStructCollection(IEnumerable<CSStruct> members) : base(members) { }
    }
}
