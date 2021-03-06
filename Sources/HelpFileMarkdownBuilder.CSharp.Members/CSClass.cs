﻿using System.Reflection;
using System.Text;

namespace HelpFileMarkdownBuilder.CSharp.Members
{
    /// <summary>
    /// C# Class
    /// </summary>
    public class CSClass : CSStrongType
    {
        /// <summary>
        /// Single member type name
        /// </summary>
        public override string SingleMemberTypeName => "Class";

        // TODO Static / Not

        // TODO Abstract / Not

        // TODO Inherited classes

        // TODO Implemented interfaces

        // TODO Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="csAssembly">Assembly</param>
        /// <param name="csNamespace">Namespace</param>
        /// <param name="type">Type</param>
        public CSClass(CSAssembly csAssembly, CSNamespace csNamespace, TypeInfo type) : base(csAssembly, csNamespace, type)
        {
            // TODO CSClass constructor
        }

        /// <summary>
        /// Gets the Markdown content for the current class
        /// </summary>
        /// <returns>Markdown content for the current class</returns>
        public override string ToMarkdown()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GetFormatedTitleMarkdown());

            builder.AppendLine($"Namespace: {Namespace.Name}"); // TODO Add link
            builder.AppendLine($"Assembly: {Assembly.Name}"); // TODO Add link
            builder.AppendLine();

            builder.AppendLine(Summary);

            // TODO CSClass ToMarkdown

            // TODO Inheritance
            // TODO Implements
            // TODO internal / public, etc

            // TODO Constructors

            // TODO Properties

            // TODO Methods

            return builder.ToString();
        }
    }
}
