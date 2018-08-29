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
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Builder\HelpFileMarkdownBuilder.CSharp.Builder.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile\HelpFileMarkdownBuilder.CSharp.Serialization.CSProjFile.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile\HelpFileMarkdownBuilder.CSharp.Serialization.XmlDocFile.csproj",
                @"..\..\..\..\Sources\HelpFileMarkdownBuilder.Serialization.SlnFile\HelpFileMarkdownBuilder.Serialization.SlnFile.csproj",
                @"..\..\..\..\Tests\HelpFileMarkdownBuilder.Tests\HelpFileMarkdownBuilder.Tests.csproj",
                @"..\..\..\..\Tests\HelpFileMarkdownBuilder.Tests.Assembly1\HelpFileMarkdownBuilder.Tests.Assembly1.csproj",
                @"..\..\..\..\Tests\HelpFileMarkdownBuilder.Tests.Assembly2\HelpFileMarkdownBuilder.Tests.Assembly2.csproj"
            };
            var l = Language.CSharp;
            l.BuildConfiguration = "Debug";
            //l.OnlyClassLibraries = true;
            HelpFileBuilder.BuildHelpFiles(examples, l);
        }
    }
}
