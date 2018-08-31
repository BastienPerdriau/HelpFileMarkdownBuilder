using System.IO;

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

        #region Help File
        /// <summary>
        /// Member file name
        /// </summary>
        public abstract string FileName { get; }

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
            return new HelpFile() {
                Name = FileName,
                Content = ToMarkdown()
            };
        }
        #endregion
    }
}
