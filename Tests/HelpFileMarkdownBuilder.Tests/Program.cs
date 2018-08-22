using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> examples = new List<string>()
            {
                "Examples/SharePointRunner.xml",
                "Examples/SharePointRunner.SDK.xml"
            };

            HelpFileBuilder.BuildHelpFiles(examples, Language.CSharp);
        }
    }
}
