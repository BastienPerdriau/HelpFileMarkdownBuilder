namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Help file built
    /// </summary>
    public class HelpFile
    {
        /// <summary>
        /// File name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// File content
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Write a help file into a physical file
        /// </summary>
        public void Write()
        {
            // TODO Check if Path exists, if not => create

            // TODO Check if Name ends with .md (insensitive), if not => add it to Name (maybe add this to set of the Name property)

            // TODO Write the file 
        }
    }
}
