namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Build configuration
    /// </summary>
    public class BuildConfiguration
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Output path
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// Documentation file path
        /// </summary>
        public string DocumentationFilePath { get; set; }
    }
}
