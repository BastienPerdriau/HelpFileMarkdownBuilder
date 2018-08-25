using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> examples = new List<string>()
            {
                //@"..\..\..\..\..\SharePointRunner\SharePointRunner.sln",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder\HelpFileMarkdownBuilder.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.Base\HelpFileMarkdownBuilder.Base.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp\HelpFileMarkdownBuilder.CSharp.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp\HelpFileMarkdownBuilder.CSharp.CSProjSerialization.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp\HelpFileMarkdownBuilder.CSharp.SlnSerialization.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp\HelpFileMarkdownBuilder.CSharp.XmlDocSerialization.csproj",
            };

            HelpFileBuilder.BuildHelpFiles(examples, Language.CSharp);
        }
    }
}
