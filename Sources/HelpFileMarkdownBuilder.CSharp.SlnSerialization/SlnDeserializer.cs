using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HelpFileMarkdownBuilder.CSharp.SlnSerialization
{
    /// <summary>
    /// C# Solution file deserializer
    /// </summary>
    public static class SlnDeserializer
    {
        /// <summary>
        /// Deserialize a C# solution file
        /// </summary>
        /// <param name="solutionFile">C# solution file</param>
        /// <returns>Sln file deserialized</returns>
        public static SlnFile Deserialize(string solutionFile)
        {
            SlnFile slnFile = new SlnFile();

            try
            {
                Regex regex = new Regex(@"^Project\(\""{[0-9a-f]{8}[-]?(?:[0-9a-f]{4}[-]?){3}[0-9a-f]{12}}\""\) = \""(?'name'[0-9a-z.]*)\"", \""(?'path'[0-9a-z.\\]*proj)\"", \""{[0-9a-f]{8}[-]?(?:[0-9a-f]{4}[-]?){3}[0-9a-f]{12}}\""$", RegexOptions.IgnoreCase & RegexOptions.Multiline);

                string fileContent = File.ReadAllText(solutionFile);

                MatchCollection matches = regex.Matches(fileContent);

                foreach (Match match in matches)
                {
                    slnFile.Projects.Add(new SlnProject()
                    {
                        Name = match.Groups["name"].Value,
                        Path = match.Groups["path"].Value
                    });
                }
            }
            catch (Exception e)
            {
                // TODO Add logs
            }

            return slnFile;
        }

    }
}
