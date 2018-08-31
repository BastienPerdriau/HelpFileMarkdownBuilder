namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Base class of a code member (class, method, ...)
    /// </summary>
    public abstract class Member
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public abstract HelpFile ToMarkdown();
    }
}
