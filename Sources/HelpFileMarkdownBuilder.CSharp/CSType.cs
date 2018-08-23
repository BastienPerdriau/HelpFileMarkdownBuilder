namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Type
    /// </summary>
    public abstract class CSType : CSMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char['T'];
    }
}
