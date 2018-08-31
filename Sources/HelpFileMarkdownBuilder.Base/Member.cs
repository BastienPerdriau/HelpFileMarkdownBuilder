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
        /// Single member type name
        /// </summary>
        public abstract string SingleMemberTypeName { get; }

        #region Help File
        /// <summary>
        /// Member file name
        /// </summary>
        public abstract string FileName { get; }

        /// <summary>
        /// Gets a Markdown array row with Name and Summary
        /// </summary>
        /// <returns>Markdown array row</returns>
        public string GetCoreMarkdown()
        {
            return this.GetArrayRowView(m => m.Name, m => m.Summary);
        }

        /// <summary>
        /// Gets the Markdown content for the current member
        /// </summary>
        /// <returns>Markdown content for the current member</returns>
        public abstract string ToMarkdown();

        /// <summary>
        /// Gets the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public HelpFile ToHelpFile()
        {
            return new HelpFile()
            {
                Name = FileName,
                Content = ToMarkdown()
            };
        }
        #endregion
    }
}
