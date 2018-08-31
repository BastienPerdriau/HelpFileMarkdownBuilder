using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// Collection of enumeration fields
    /// </summary>
    public class CSEnumerationFieldCollection : CSMemberCollection<CSEnumerationField>
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Fields";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public CSEnumerationFieldCollection() : base() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public CSEnumerationFieldCollection(IEnumerable<CSEnumerationField> members) : base(members) { }
    }
}
