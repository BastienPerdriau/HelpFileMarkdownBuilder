﻿using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.CSProjSerialization
{
    /// <summary>
    /// DocumentationFile node
    /// </summary>
    [XmlType("DocumentationFile")]
    public class XmlDocumentationFile
    {
        /// <summary>
        /// Value of the DocumentationFile node
        /// </summary>
        [XmlText]
        public string Value { get; set; } = string.Empty;
    }
}
