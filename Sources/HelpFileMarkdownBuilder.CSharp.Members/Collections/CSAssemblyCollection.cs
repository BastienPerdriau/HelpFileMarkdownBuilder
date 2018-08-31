using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of assemblies
    /// </summary>
    public class CSAssemblyCollection : CSMemberCollection<CSAssembly>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Assemblies";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSAssemblyCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSAssemblyCollection(IEnumerable<CSAssembly> members) : base(members) { }
    }
}
