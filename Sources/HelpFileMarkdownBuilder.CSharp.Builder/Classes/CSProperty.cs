using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// C# Property
    /// </summary>
    public class CSProperty : CSStrongTypeMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'P', 'F' };

        // TODO Public / Private / ...

        // TODO Get, set, readonly

        // TODO Static / not

        // TODO Abstract / not

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csStrongType">Strong Type</param>
        public CSProperty(CSStrongType csStrongType) : base(csStrongType) { }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSProperty ToMarkdown
            return null;
        }
    }
}
