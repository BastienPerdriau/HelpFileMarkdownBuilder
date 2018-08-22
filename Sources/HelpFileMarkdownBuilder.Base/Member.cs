namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Base class of a code member (class, method, ...)
    /// </summary>
    public abstract class Member
    {
        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public abstract HelpFile ToMarkdown();
    }
}
