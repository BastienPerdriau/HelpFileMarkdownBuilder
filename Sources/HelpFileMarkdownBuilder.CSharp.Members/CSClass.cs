using System.Reflection;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Class
    /// </summary>
    public class CSClass : CSStrongType
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Class";

        /// <summary>
        /// Multiple member type name
        /// </summary>
        public override string MultipleMemberTypeName => "Classes";

        /// <summary>
        /// Member file name
        /// </summary>
        public override string FileName => $"{Namespace.Name}.{Name}.{SingleMemberTypeName}.md";

        // TODO Static / Not

        // TODO Abstract / Not

        // TODO Inherited classes

        // TODO Implemented interfaces

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSClass(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type)
        {
            // TODO CSClass constructor
        }

        /// <summary>
        /// Gets the Markdown content for the current class
        /// </summary>
        /// <returns>Markdown content for the current class</returns>
        public override string ToMarkdown()
        {
            // TODO CSClass ToMarkdown
            return string.Empty;
        }
    }
}
