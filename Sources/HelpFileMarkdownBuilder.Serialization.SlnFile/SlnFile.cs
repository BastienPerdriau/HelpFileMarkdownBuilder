using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.Serialization.SlnFile
{
    /// <summary>
    /// Root of the solution file
    /// </summary>
    public class SlnFile
    {
        /// <summary>
        /// Projects
        /// </summary>
        public List<SlnProject> Projects { get; } = new List<SlnProject>();
    }
}
