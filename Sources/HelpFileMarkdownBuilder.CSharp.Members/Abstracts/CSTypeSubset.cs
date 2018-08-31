using System.Linq;
using System.Text;

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

        /// <summary>
        /// Structs
        /// </summary>
        public CSStructCollection Structs => new CSStructCollection(Types.OfType<CSStruct>());

        /// <summary>
        /// Gets the Markdown content for the current namespace
        /// </summary>
        /// <returns>Markdown content for the current namespace</returns>
        public override string ToMarkdown()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GetFormatedTitleMarkdown());

            builder.AppendLine(Summary);

            builder.AppendLine(Classes.GetCoreListView());
            builder.AppendLine(Interfaces.GetCoreListView());
            builder.AppendLine(Enumerations.GetCoreListView());
            builder.AppendLine(Structs.GetCoreListView());

            return builder.ToString();
        }
    }
}
