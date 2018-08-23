namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# String type (class or interface)
    /// </summary>
    public abstract class CSStrongType : CSType
    {
        // TODO Properties

        // TODO Methods

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        public CSStrongType(CSAssembly csAssembly, CSNamespace csNamespace) : base(csAssembly, csNamespace) { }
    }
}
