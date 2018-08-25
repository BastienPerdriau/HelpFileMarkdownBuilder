namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// C# Type
    /// </summary>
    public abstract class CSType : CSMember
    {
        /// <summary>
        /// Assembly
        /// </summary>
        public CSAssembly Assembly { get; }

        /// <summary>
        /// Namespace
        /// </summary>
        public CSNamespace Namespace { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        public CSType(CSAssembly csAssembly, CSNamespace csNamespace)
        {
            Assembly = csAssembly;
            Namespace = csNamespace;
        }

        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char['T'];
    }
}
