using System.Collections.Generic;

namespace HelpFileMarkdownBuilder.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> examples = new List<string>()
            {
                @"..\..\..\..\..\SharePointRunner\SharePointRunner.sln",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder\HelpFileMarkdownBuilder.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.Base\HelpFileMarkdownBuilder.Base.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Builder\HelpFileMarkdownBuilder.CSharp.Builder.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile\HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile\HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.Serialization.SlnFile\HelpFileMarkdownBuilder.Serialization.SlnFile.csproj"
            };
            var l = Language.CSharp;
            l.BuildConfiguration = "aaaaaa";
            HelpFileBuilder.BuildHelpFiles(examples, l);
        }
    }
}
