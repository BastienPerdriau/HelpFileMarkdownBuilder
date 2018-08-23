namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Help file built
    /// </summary>
    public class HelpFile
    {
        /// <summary>
        /// File path
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// File name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// File content
        /// </summary>
        public string Content { get; set; } = string.Empty;
    }
}
