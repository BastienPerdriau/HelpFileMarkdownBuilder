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
                Regex regex = new Regex(@"^Project\(\""{[0-9a-f]{8}[-]?(?:[0-9a-f]{4}[-]?){3}[0-9a-f]{12}}\""\) = \""(?'name'[0-9a-z.]*)\"", \""(?'path'[0-9a-z.\\]*proj)\"", \""{[0-9a-f]{8}[-]?(?:[0-9a-f]{4}[-]?){3}[0-9a-f]{12}}\""$", RegexOptions.IgnoreCase);

                string[] lines = File.ReadAllLines(solutionFile);
                
                foreach (string line in lines)
                {
                    Match match = regex.Match(line);

                    if (match.Success)
                    {
                        slnFile.Projects.Add(new SlnProject()
                        {
                            Name = match.Groups["name"].Value,
                            Path = Path.Combine(Path.GetDirectoryName(solutionFile), match.Groups["path"].Value) // Relative file path
                            //Path = Path.Combine(new FileInfo(solutionFile).Directory.FullName, match.Groups["path"].Value) // Full file path
                        });
                    }
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
