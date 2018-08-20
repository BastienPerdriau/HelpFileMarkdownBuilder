using HelpFileMarkdownBuilder.Base;
using System.Collections.Generic;

namespace HelpFileMarkdownBuilder
{
    /// <summary>
    /// Help file builder
    /// </summary>
    public class HelpFileBuilder
    {
        /// <summary>
        /// Build help files
        /// </summary>
        /// <param name="sourceFiles">Files to build help files from</param>
        /// <param name="language">Language to build help file</param>
        public static void BuildHelpFiles(List<string> sourceFiles, Language language)
        {
            Builder builder = language.Builder;
            builder.SourceFiles = sourceFiles;

            List<string> files = builder.BuildHelpFiles();
        }
    }
}
