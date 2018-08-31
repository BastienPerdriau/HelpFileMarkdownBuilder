using System.IO;

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
        /// <param name="folderPath">Folderf path where write the file</param>
        public void Write(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                // TODO Logs warn
                return;
            }

            // Write the file
            using (StreamWriter writer = File.CreateText(Path.Combine(folderPath, Name)))
            {
                writer.Write(Content);
            }

            // TODO Logs Info
        }
    }
}
