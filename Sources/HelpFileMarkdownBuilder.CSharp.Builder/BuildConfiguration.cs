using System.IO;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Build configuration
    /// </summary>
    public class BuildConfiguration
    {
        private string outputPath = string.Empty;

        private string documentationFilePath = string.Empty;

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Output path
        /// </summary>
        public string OutputPath
        {
            get
            {
                return outputPath;
            }
            set
            {
                if (File.Exists(value))
                {
                    outputPath = value;
                }
                else
                {
                    // Logs warn
                }
            }
        }

        /// <summary>
        /// Documentation file path
        /// </summary>
        public string DocumentationFilePath
        {
            get
            {
                return documentationFilePath;
            }
            set
            {
                if (File.Exists(value))
                {
                    documentationFilePath = value;
                }
                else
                {
                    // Logs info
                }
            }
        }
    }
}
