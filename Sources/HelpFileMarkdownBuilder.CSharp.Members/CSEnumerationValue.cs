namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Enumeration value
    /// </summary>
    public class CSEnumerationValue : CSMember
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Enumeration value";

        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Enumeration values";

        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'F' };

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public override string XmlFullName => string.Empty; // TODO CSEnumerationValue XmlFullName

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Enumeration.Namespace.Name}.{Enumeration.Name}.{Name}.{SingleMemberTypeName}.md";

        /// <summary>
        /// Enumeration
        /// </summary>
        public CSEnumeration Enumeration { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csEnumeration">Enumeration</param>
        public CSEnumerationValue(CSEnumeration csEnumeration)
        {
            Enumeration = csEnumeration;
        }

        /// <summary>
        /// Gets the Markdown content for the current enumeration value
        /// </summary>
        /// <returns>Markdown content for the current enumeration value</returns>
        public override string ToMarkdown()
        {
            // TODO CSEnumerationValue ToMarkdown
            return string.Empty;
        }
    }
}
