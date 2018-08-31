using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Property
    /// </summary>
    public class CSProperty : CSStrongTypeMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'P', 'F' };

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public override string XmlFullName => string.Empty; // TODO CSProperty XmlFullName

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{StrongType.Namespace.Name}.{StrongType.Name}.{Name}.Property.md";

        // TODO Public / Private / ...

        // TODO Get, set, readonly

        // TODO Static / not

        // TODO Abstract / not

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csStrongType">Strong Type</param>
        public CSProperty(CSStrongType csStrongType) : base(csStrongType) { }

        /// <summary>
        /// Gets the Markdown content for the current property
        /// </summary>
        /// <returns>Markdown content for the current property</returns>
        public override string ToMarkdown()
        {
            // TODO CSProperty ToMarkdown
            return string.Empty;
        }
    }
}
