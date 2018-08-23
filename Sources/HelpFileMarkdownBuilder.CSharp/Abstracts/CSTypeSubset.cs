using System.Collections.Generic;
using System.Linq;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Type subset
    /// </summary>
    public abstract class CSTypeSubset : CSMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { };

        /// <summary>
        /// Types
        /// </summary>
        public List<CSType> Types { get; set; } = new List<CSType>();

        /// <summary>
        /// Enumerations
        /// </summary>
        public List<CSEnumeration> Enumerations => Types.OfType<CSEnumeration>().ToList();

        /// <summary>
        /// Classes
        /// </summary>
        public List<CSClass> Classes => Types.OfType<CSClass>().ToList();

        /// <summary>
        /// Interfaces
        /// </summary>
        public List<CSInterface> Interfaces => Types.OfType<CSInterface>().ToList();
    }
}
