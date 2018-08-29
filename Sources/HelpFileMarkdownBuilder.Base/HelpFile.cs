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

        public void Write()
        {
            // TODO Check if Path exists, if not => create

            // TODO Check if Name ends with .md (insensitive), if not => add it to Name (maybe add this to set of the Name property)

            // TODO Write the file 
        }
    }
}
