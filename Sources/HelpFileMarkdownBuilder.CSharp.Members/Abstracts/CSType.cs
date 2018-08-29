using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Members
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

        /// <summary>
        /// Full name in XML documentation file
        /// </summary>
        public override string XmlFullName => string.Empty; // TODO CSMethod XmlFullName
        
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
        /// <param name="type">Type</param>
        public CSType(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type)
        {
            Assembly = csAssembly;
            Namespace = csNamespace;
        }

        
    }
}
