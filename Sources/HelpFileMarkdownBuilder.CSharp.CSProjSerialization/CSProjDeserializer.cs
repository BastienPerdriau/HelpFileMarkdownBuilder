using System;
using System.IO;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.CSProjSerialization
{
    /// <summary>
    /// C# csproj file deserializer
    /// </summary>
    public static class CSProjDeserializer
    {
        /// <summary>
        /// Deserialize a C# XML csproj file
        /// </summary>
        /// <param name="projectFile">C# XML csproj file</param>
        /// <returns>Csproj file deserialized</returns>
        public static XmlProject Deserialize(string projectFile)
        {
            XmlProject docFile = default;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XmlProject));
                using (var reader = new StreamReader(projectFile))
                {
                    docFile = (XmlProject)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                // TODO Add logs
            }

            return docFile;
        }
    }
}
