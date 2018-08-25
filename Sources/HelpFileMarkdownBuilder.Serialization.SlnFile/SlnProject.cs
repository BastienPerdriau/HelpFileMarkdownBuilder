namespace HelpFileMarkdownBuilder.Serialization.SlnFile
{
    /// <summary>
    /// Project in solution file
    /// </summary>
    public class SlnProject
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        // TODO Get relative path
        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; set; } = string.Empty;
    }
}
