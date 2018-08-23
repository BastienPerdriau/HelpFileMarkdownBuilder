using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Namespace
    /// </summary>
    public class CSNamespace : CSMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { };

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSNamespace ToMarkdown
            return null;
        }
    }
}
