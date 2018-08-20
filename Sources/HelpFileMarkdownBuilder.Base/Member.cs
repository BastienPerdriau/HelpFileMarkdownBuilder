namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Base class of a code member (class, method, ...)
    /// </summary>
    public abstract class Member
    {
        /// <summary>
        /// Return the string value of the markdown from this member
        /// </summary>
        /// <returns>String value of markdown</returns>
        public abstract string ToMarkdown();
    }
}
