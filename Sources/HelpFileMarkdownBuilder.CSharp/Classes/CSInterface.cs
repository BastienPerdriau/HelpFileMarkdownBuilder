﻿using HelpFileMarkdownBuilder.Base;

namespace HelpFileMarkdownBuilder.CSharp
{
    /// <summary>
    /// C# Interface
    /// </summary>
    public class CSInterface : CSStrongType
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        public CSInterface(CSAssembly csAssembly, CSNamespace csNamespace) : base(csAssembly, csNamespace) { }

        /// <summary>
        /// Return the help file to build
        /// </summary>
        /// <returns>Help file to build</returns>
        public override HelpFile ToMarkdown()
        {
            // TODO CSInterface ToMarkdown
            return null;
        }
    }
}