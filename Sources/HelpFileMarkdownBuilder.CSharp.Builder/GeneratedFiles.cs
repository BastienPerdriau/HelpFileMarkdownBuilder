using System.IO;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Enumeration of generated files states
    /// </summary>
    public enum GeneratedFilesState
    {
        /// <summary>
        /// Both
        /// </summary>
        Both,

        /// <summary>
        /// Only assembly
        /// </summary>
        OnlyAssembly
    }

    /// <summary>
    /// Class with generated assembly and documentation files
    /// </summary>
    public class GeneratedFiles
    {
        /// <summary>
        /// Generated files state
        /// </summary>
        public GeneratedFilesState State { get; internal set; }

        /// <summary>
        /// Generated assembly file
        /// </summary>
        public FileStream AssemblyFile { get; internal set; }

        /// <summary>
        /// Generated documentation file
        /// </summary>
        public FileStream DocumentationFile { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="assemblyFile">Assembly file</param>
        /// <param name="documentationFile">Documentation file</param>
        public GeneratedFiles(FileStream assemblyFile, FileStream documentationFile)
        {
            if (assemblyFile != null && documentationFile != null)
            {
                State = GeneratedFilesState.Both;
            }
            else if (assemblyFile != null)
            {
                State = GeneratedFilesState.OnlyAssembly;
                // TODO Logs warn
            }
            else
            {
                // TODO Logs warn
            }
        }
    }
}
