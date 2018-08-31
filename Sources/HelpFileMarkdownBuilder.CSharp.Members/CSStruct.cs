using System.Reflection;
using System.Text;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Struct
    /// </summary>
    public class CSStruct : CSType
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Struct";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSStruct(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type)
        {
            // TODO CSStruct constructor
        }

        /// <summary>
        /// Gets the Markdown content for the current struct
        /// </summary>
        /// <returns>Markdown content for the current struct</returns>
        public override string ToMarkdown()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GetFormatedTitleMarkdown());

            builder.AppendLine($"Namespace: {Namespace.Name}"); // TODO Add link
            builder.AppendLine($"Assembly: {Assembly.Name}"); // TODO Add link
            builder.AppendLine();

            builder.AppendLine(Summary);

            // TODO CSStruct ToMarkdown

            return builder.ToString();
        }
    }
}
