using HelpFileMarkdownBuilder.Base;
using HelpFileMarkdownBuilder.CSharp.Builder;

namespace HelpFileMarkdownBuilder
{
    /// <summary>
    /// C-Sharp language
    /// </summary>
    public class CSharpLanguage : Language
    {
        /// <summary>
        /// Short name
        /// </summary>
        public override string ShortName => "C#";

        /// <summary>
        /// Full name
        /// </summary>
        public override string FullName => "C-Sharp";

        /// <summary>
        /// Assemblies build configuration
        /// </summary>
        public string BuildConfiguration
        {
            get
            {
                return ((CSharpBuilder)Builder).BuildConfiguration;
            }
            set
            {
                ((CSharpBuilder)Builder).BuildConfiguration = value;
            }
        }

        /// <summary>
        /// Builder
        /// </summary>
        internal override Builder Builder { get; } = new CSharpBuilder();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Key</param>
        internal CSharpLanguage(int key) : base(key) { }


    }
}
