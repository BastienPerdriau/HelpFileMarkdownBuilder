using System.Text.RegularExpressions;

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
        public string Path { get; set; } = "/";

        /// <summary>
        /// File name
        /// </summary>
        private string name;

        /// <summary>
        /// File name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // If file name does not finish a Markdown extension, add .md
                if (!Regex.IsMatch(value, ".(?:md|markdown|mdown|markdn|workbook)$", RegexOptions.IgnoreCase))
                {
                    value = $"{value}.md";
                }

                name = value;
            }
        }

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
