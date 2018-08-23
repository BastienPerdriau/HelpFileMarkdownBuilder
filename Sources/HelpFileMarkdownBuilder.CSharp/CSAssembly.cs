using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Assembly
    /// </summary>
    public class CSAssembly : CSMember
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
            // TODO CSAssembly ToMarkdown
            return null;
        }
    }
}
