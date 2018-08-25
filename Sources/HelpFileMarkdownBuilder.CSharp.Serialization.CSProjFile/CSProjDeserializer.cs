using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile
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
            XmlProject projFile = default;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XmlProject));
                using (StreamReader reader = new StreamReader(projectFile, Encoding.UTF8))
                {
                    projFile = (XmlProject)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                // TODO Add logs
            }

            return projFile;
        }
    }
}
