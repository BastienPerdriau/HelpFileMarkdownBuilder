using System.Linq;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Type subset (Assemblies, Namesapces)
    /// </summary>
    public abstract class CSTypeSubset : CSMember
    {
        /// <summary>
        /// Member full name
        /// </summary>
        public override string FullName => Name;

        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { };

        /// <summary>
        /// Types
        /// </summary>
        public CSTypeCollection Types { get; set; } = new CSTypeCollection();

        /// <summary>
        /// Enumerations
        /// </summary>
        public CSEnumerationCollection Enumerations => new CSEnumerationCollection(Types.OfType<CSEnumeration>());

        /// <summary>
        /// Classes
        /// </summary>
        public CSClassCollection Classes => new CSClassCollection(Types.OfType<CSClass>());

        /// <summary>
        /// Interfaces
        /// </summary>
        public CSInterfaceCollection Interfaces => new CSInterfaceCollection(Types.OfType<CSInterface>());
    }
}
