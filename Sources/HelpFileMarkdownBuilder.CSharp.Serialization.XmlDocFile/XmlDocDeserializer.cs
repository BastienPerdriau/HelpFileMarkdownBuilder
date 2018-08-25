using System;
using System.IO;
using System.Xml.Serialization;

namespace HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile
{
    /// <summary>
    /// C# XML documentation file deserializer
    /// </summary>
    public static class XmlDocDeserializer
    {
        /// <summary>
        /// Deserialize a C# XML documentation file
        /// </summary>
        /// <param name="documentationFile">C# XML documentation file</param>
        /// <returns>Documentation file deserialized</returns>
        public static XmlDoc Deserialize(string documentationFile)
        {
            XmlDoc docFile = default;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XmlDoc));
                using (StreamReader reader = new StreamReader(documentationFile))
                {
                    docFile = (XmlDoc)serializer.Deserialize(reader);
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
