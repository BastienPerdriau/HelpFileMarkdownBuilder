namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Method
    /// </summary>
    public class CSMethod : CSStrongTypeMember
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Method";

        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'M' };

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{StrongType.Namespace.Name}.{StrongType.Name}.{Name}.{SingleMemberTypeName}.md";

        // TODO Parameters

        // TODO Public / Private / ...

        // TODO Override / Not

        // TODO Overrides in class

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csStrongType">Strong Type</param>
        public CSMethod(CSStrongType csStrongType) : base(csStrongType) { }

        /// <summary>
        /// Gets the Markdown content for the current method
        /// </summary>
        /// <returns>Markdown content for the current method</returns>
        public override string ToMarkdown()
        {
            // TODO CSMethod ToMarkdown
            return string.Empty;
        }
    }
}
