using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Class
    /// </summary>
    public class CSClass : CSStrongType
    {
        // TODO Static / Not

        // TODO Abstract / Not

        // TODO Inherited classes

        // TODO Implemented interfaces

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        public CSClass(CSAssembly csAssembly, CSNamespace csNamespace) : base(csAssembly, csNamespace) { }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSClass ToMarkdown
            return null;
        }
    }
}
