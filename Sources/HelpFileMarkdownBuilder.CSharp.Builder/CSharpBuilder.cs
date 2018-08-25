using HelpFileMarkdownBuilder.Base;
using HelpFileMarkdownBuilder.CSharp.CSProjSerialization;
using HelpFileMarkdownBuilder.CSharp.SlnSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace HelpFileMarkdownBuilder.CSharp.Builder
{
    /// <summary>
    /// Builder class of CSharp help file documentation
    /// </summary>
    public class CSharpBuilder : Base.Builder
    {
        /// <summary>
        /// Assemblies build configuration
        /// </summary>
        public string BuildConfiguration { get; set; }// = "Release";

        /// <summary>
        /// Build help files from XML documentation files and assemblies
        /// </summary>
        /// <returns>Markdown documentation generated from build</returns>
        public override List<HelpFile> BuildHelpFiles()
        {
            //foreach (string file in SourceFiles)
            //{
            //    XmlDoc docFile = CSXmlDeserializer.Deserialize(file);

            //    List<string> tmp = docFile.Members.Select(m => m.Name.Substring(0, 1)).Distinct().ToList();

            //    string xml = File.ReadAllText(file);
            //    XDocument doc = XDocument.Parse(xml);
            //    string md = doc.Root.ToMarkDown();
            //}

            List<string> projectFiles = GetProjectFiles();

            List<XmlProject> deserializedProjectFiles = projectFiles.Select(f => CSProjDeserializer.Deserialize(f)).ToList();

            // TODO for each deserialized project files, find generated dlls (if not => error) and generated documentation files (if not => warning)

            List<GeneratedFiles> generatedFiles = new List<GeneratedFiles>(); // TODO

            // TODO From dlls, create CSAssembly and CSNamespace class, then CSType (CSClass, CSInterface, CSEnumeration), then CSProperty and CSMethod, and then consolidate with documentation

            List<HelpFile> results = new List<HelpFile>();

            return results;
        }

        /// <summary>
        /// Gets the project files from source files
        /// </summary>
        /// <returns>List of project files</returns>
        private List<string> GetProjectFiles()
        {
            List<string> projectFiles = new List<string>();

            foreach (string sourceFile in SourceFiles)
            {
                if (Regex.IsMatch(sourceFile, @"([a-zA-Z\u00C0-\u024F0-9\s_\\.\-\(\):])+(\.csproj)$", RegexOptions.IgnoreCase))
                {
                    projectFiles.Add(sourceFile);
                    // TODO Logs debug
                }
                else if (Regex.IsMatch(sourceFile, @"([a-zA-Z\u00C0-\u024F0-9\s_\\.\-\(\):])+(\.sln)$", RegexOptions.IgnoreCase))
                {
                    SlnFile slnFile = SlnDeserializer.Deserialize(sourceFile);
                    projectFiles.AddRange(slnFile.Projects.Select(p => p.Path));
                    // TODO Logs debug
                }
                else
                {
                    // TODO Logs warn source file not good
                }
            }

            return projectFiles;
        }
    }

    static class XmlToMarkdown
    {
        internal static string ToMarkDown(this XNode e)
        {
            var templates = new Dictionary<string, string>
                {
                    {"doc", "## {0} ##\n\n{1}\n\n"},
                    {"type", "# {0}\n\n{1}\n\n---\n"},
                    {"field", "##### {0}\n\n{1}\n\n---\n"},
                    {"property", "##### {0}\n\n{1}\n\n---\n"},
                    {"method", "##### {0}\n\n{1}\n\n---\n"},
                    {"event", "##### {0}\n\n{1}\n\n---\n"},
                    {"summary", "{0}\n\n"},
                    {"remarks", "\n\n>{0}\n\n"},
                    {"example", "_C# code_\n\n```c#\n{0}\n```\n\n"},
                    {"seePage", "[[{1}|{0}]]"},
                    {"seeAnchor", "[{1}]({0})"},
                    {"param", "|Name | Description |\n|-----|------|\n|{0}: |{1}|\n" },
                    {"exception", "[[{0}|{0}]]: {1}\n\n" },
                    {"returns", "Returns: {0}\n\n"},
                    {"none", ""}
                };

            var d = new Func<string, XElement, string[]>((att, node) => new[]
                {
                    node.Attribute(att).Value,
                    node.Nodes().ToMarkDown()
                });

            var methods = new Dictionary<string, Func<XElement, IEnumerable<string>>>
                {
                    {"doc", x=> new[]{
                        x.Element("assembly").Element("name").Value,
                        x.Element("members").Elements("member").ToMarkDown()
                    }},
                    {"type", x=>d("name", x)},
                    {"field", x=> d("name", x)},
                    {"property", x=> d("name", x)},
                    {"method",x=>d("name", x)},
                    {"event", x=>d("name", x)},
                    {"summary", x=> new[]{ x.Nodes().ToMarkDown() }},
                    {"remarks", x => new[]{x.Nodes().ToMarkDown()}},
                    {"example", x => new[]{x.Value.ToCodeBlock()}},
                    {"seePage", x=> d("cref", x) },
                    {"seeAnchor", x=> { var xx = d("cref", x); xx[0] = xx[0].ToLower(); return xx; }},
                    {"param", x => d("name", x) },
                    {"exception", x => d("cref", x) },
                    {"returns", x => new[]{x.Nodes().ToMarkDown()}},
                    {"none", x => new string[0]}
                };

            string name;
            if (e.NodeType == XmlNodeType.Element)
            {
                var el = (XElement)e;
                name = el.Name.LocalName;

                if (name == "member")
                {
                    switch (el.Attribute("name").Value[0])
                    {
                        case 'F':
                            name = "field";
                            break;
                        case 'P':
                            name = "property";
                            break;
                        case 'T':
                            name = "type";
                            break;
                        case 'E':
                            name = "event";
                            break;
                        case 'M':
                            name = "method";
                            break;
                        default:
                            name = "none";
                            break;
                    }
                }
                if (name == "see")
                {
                    var anchor = el.Attribute("cref").Value.StartsWith("!:#");
                    name = anchor ? "seeAnchor" : "seePage";
                }

                string str = "";
                if (methods.ContainsKey(name))
                {
                    var vals = methods[name](el).ToArray();
                    switch (vals.Length)
                    {
                        case 1:
                            str = string.Format(templates[name], vals[0]);
                            break;
                        case 2:
                            str = string.Format(templates[name], vals[0], vals[1]);
                            break;
                        case 3:
                            str = string.Format(templates[name], vals[0], vals[1], vals[2]);
                            break;
                        case 4:
                            str = string.Format(templates[name], vals[0], vals[1], vals[2], vals[3]);
                            break;
                    }
                }

                return str;
            }

            if (e.NodeType == XmlNodeType.Text)
            {
                return Regex.Replace(((XText)e).Value.Replace('\n', ' '), @"\s+", " ");
            }

            return "";
        }

        internal static string ToMarkDown(this IEnumerable<XNode> es)
        {
            return es.Aggregate("", (current, x) => current + x.ToMarkDown());
        }

        static string ToCodeBlock(this string s)
        {
            var lines = s.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var blank = lines[0].TakeWhile(x => x == ' ').Count() - 4;
            return string.Join("\n", lines.Select(x => new string(x.SkipWhile((y, i) => i < blank).ToArray())));
        }
    }
}
