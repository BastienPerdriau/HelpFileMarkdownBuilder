using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Member
    /// </summary>
    public abstract class CSMember : Member
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public abstract char[] XmlPrefixName { get; }

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
