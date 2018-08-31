namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Strong type member (property or method)
    /// </summary>
    public abstract class CSStrongTypeMember : CSMember
    {
        /// <summary>
        /// Member full name
        /// </summary>
        public override string FullName => $"{StrongType.FullName}.{Name}";

        /// <summary>
        /// Strong Type
        /// </summary>
        public CSStrongType StrongType { get; }

        // TODO Maybe not string
        /// <summary>
        /// Return type
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csStrongType">Strong Type</param>
        public CSStrongTypeMember(CSStrongType csStrongType)
        {
            StrongType = csStrongType;
        }
    }
}
