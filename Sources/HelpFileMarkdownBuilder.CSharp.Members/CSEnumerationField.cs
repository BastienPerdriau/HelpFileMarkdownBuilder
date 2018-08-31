namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Enumeration field
    /// </summary>
    public class CSEnumerationField : CSMember
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Field";

        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'F' };

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public override string XmlFullName => string.Empty; // TODO CSEnumerationField XmlFullName

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
        public CSEnumerationField(CSEnumeration csEnumeration)
        {
            Enumeration = csEnumeration;
        }

        /// <summary>
        /// Gets the Markdown content for the current enumeration field
        /// </summary>
        /// <returns>Markdown content for the current enumeration field</returns>
        public override string ToMarkdown()
        {
            // TODO CSEnumerationField ToMarkdown
            return string.Empty;
        }
    }
}
