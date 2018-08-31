using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Member
    /// </summary>
    public abstract class CSMember : Member
    {
        /// <summary>
        /// Member full name
        /// </summary>
        public virtual string FullName { get; protected set; }
        
        /// <summary>
        /// Prefix of the name in XML documentation file
        /// </summary>
        public abstract char[] XmlPrefixName { get; }

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public string XmlFullName => $"{XmlPrefixName}:{FullName}";
    }
}
