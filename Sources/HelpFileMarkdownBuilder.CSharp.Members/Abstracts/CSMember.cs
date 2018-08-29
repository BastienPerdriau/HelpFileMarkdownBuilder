using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Member
    /// </summary>
    public abstract class CSMember : Member
    {
        /// <summary>
        /// Prefix of the name in XML documentation file
        /// </summary>
        public abstract char[] XmlPrefixName { get; }

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public abstract string XmlFullName { get; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; } = string.Empty;
    }
}
