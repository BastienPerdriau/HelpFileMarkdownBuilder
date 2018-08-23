using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
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
