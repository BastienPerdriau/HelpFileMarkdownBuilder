namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Namespace
    /// </summary>
    public class CSNamespace : CSTypeSubset
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Namespace";

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Name}.{SingleMemberTypeName}.md";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        public CSNamespace(string name)
        {
            Name = name;
        }
    }
}
