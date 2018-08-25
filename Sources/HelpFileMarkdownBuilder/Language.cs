using HelpFileMarkdownBuilder.Base;
using HelpFileMarkdownBuilder.CSharp.Builder;
using System;
using System.Linq;

namespace HelpFileMarkdownBuilder
{
    /// <summary>
    /// Languages to build help files
    /// </summary>
    public abstract class Language : Enumeration
    {
        /// <summary>
        /// C#
        /// </summary>
        public static CSharpLanguage CSharp => new CSharpLanguage(0);

        /// <summary>
        /// Short name
        /// </summary>
        public abstract string ShortName { get; }

        /// <summary>
        /// Full name
        /// </summary>
        public abstract string FullName { get; }

        /// <summary>
        /// Builder
        /// </summary>
        internal abstract Builder Builder { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Key</param>
        protected Language(int key) : base(key) { }

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
