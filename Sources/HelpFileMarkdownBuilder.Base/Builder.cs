using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Base class for help file builder
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// Files to build help files from
        /// </summary>
        public List<string> SourceFiles = new List<string>();
        
        /// <summary>
        /// Build help files from source code or XML documentation
        /// </summary>
        /// <returns>Help files generated</returns>
        public abstract List<HelpFile> BuildHelpFiles();
    }
}
