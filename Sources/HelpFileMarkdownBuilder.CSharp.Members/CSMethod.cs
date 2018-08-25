using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Method
    /// </summary>
    public class CSMethod : CSStrongTypeMember
    {
        /// <summary>
        /// Prefix of the name in Xml documentation file
        /// </summary>
        public override char[] XmlPrefixName => new char[] { 'M' };

        // TODO Parameters

        // TODO Public / Private / ...

        // TODO Override / Not

        // TODO Overrides in class

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csStrongType">Strong Type</param>
        public CSMethod(CSStrongType csStrongType) : base(csStrongType) { }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSMethod ToMarkdown
            return null;
        }
    }
}
