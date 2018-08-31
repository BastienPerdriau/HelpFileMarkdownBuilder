using HelpFileMarkdownBuilder.Base;
using System;
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
            builder.ProjectName = "My awesome project";
            builder.ProjectVersion = "1.0.0.0";

            List<HelpFile> files = builder.BuildHelpFiles();

            files.ForEach(f => f.Write(Environment.CurrentDirectory));
        }
    }
}
