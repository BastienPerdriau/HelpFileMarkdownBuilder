﻿using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
{
    /// <summary>
    /// PropertyGroup node
    /// </summary>
    [XmlType("PropertyGroup")]
    public class XmlPropertyGroup
    {
        /// <summary>
        /// Condition attribute
        /// </summary>
        [XmlAttribute("Condition")]
        public string Condition { get; set; } = null;

        /// <summary>
        /// OutputType node
        /// </summary>
        [XmlElement("OutputType")]
        public XmlOutputType OutputType { get; set; } = null;

        /// <summary>
        /// AssemblyName node
        /// </summary>
        [XmlElement("AssemblyName")]
        public XmlAssemblyName AssemblyName { get; set; } = null;

        /// <summary>
        /// OutputPath node
        /// </summary>
        [XmlElement("OutputPath")]
        public XmlOutputPath OutputPath { get; set; } = null;

        /// <summary>
        /// DocumentationFile node
        /// </summary>
        [XmlElement("DocumentationFile")]
        public XmlDocumentationFile DocumentationFile { get; set; } = null;
    }
}
