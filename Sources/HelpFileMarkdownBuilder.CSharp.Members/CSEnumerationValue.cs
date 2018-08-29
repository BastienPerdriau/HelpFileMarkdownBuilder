using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Enumeration value
    /// </summary>
    public class CSEnumerationValue : CSMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'F' };

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public override string XmlFullName => string.Empty; // TODO CSEnumerationValue XmlFullName

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
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSEnumerationValue ToMarkdown
            return null;
        }
    }
}
