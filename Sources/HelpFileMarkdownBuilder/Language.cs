using HelpFileMarkdownBuilder.Base;
using HelpFileMarkdownBuilder.CSharp;
using System;
using System.Linq;

namespace HelpFileMarkdownBuilder
{
    /// <summary>
    /// Languages to build help files
    /// </summary>
    public class Language : Enumeration
    {
        /// <summary>
        /// C#
        /// </summary>
        public static Language CSharp => new Language(0, "C#", "C-Sharp", new CSharpBuilder());

        /// <summary>
        /// Short name
        /// </summary>
        public string ShortName { get; internal set; }

        /// <summary>
        /// Full name
        /// </summary>
        public string FullName { get; internal set; }

        /// <summary>
        /// Builder
        /// </summary>
        public Builder Builder { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="shortName">Short name</param>
        /// <param name="fullName">Full name</param>
        /// <param name="builder">Builder</param>
        private Language(int key, string shortName, string fullName, Builder builder) : base(key)
        {
            ShortName = shortName;
            FullName = fullName;
            Builder = builder;
        }

        /// <summary>
        /// Gets a language by it short name
        /// </summary>
        /// <param name="shortName">Short name</param>
        /// <returns>Language</returns>
        public static Language FromShortName(string shortName)
        {
            return List<Language>().Single(l => string.Equals(l.ShortName, shortName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Gets a language by it full name
        /// </summary>
        /// <param name="fullName">Full name</param>
        /// <returns>Language</returns>
        public static Language FromFullName(string fullName)
        {
            return List<Language>().Single(l => string.Equals(l.FullName, fullName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
