using System.Text;
using Xunit;

namespace HelpFileMarkdownBuilder.Base.Tests
{
    internal class MemberTest : Member
    {
        public override string SingleMemberTypeName => "TestMember";

        public override string FileName => $"{SingleMemberTypeName}.md";

        public override string ToMarkdown()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"# {Name}");
            builder.AppendLine($"#### {Summary}");

            return builder.ToString();
        }
    }

    public class MemberTests
    {
        private MemberTest member;

        public MemberTests()
        {
            member = new MemberTest()
            {
                Name = "MyTestMember",
                Summary = "The summary of my test member"
            };
        }

        [Fact]
        public void GetFormatedTitleMarkdownTest()
        {
            Assert.Equal($"# {member.Name} {member.SingleMemberTypeName}", member.GetFormatedTitleMarkdown());
        }

        [Fact]
        public void GetCoreMarkdownTest()
        {
            Assert.Equal($"|{member.Name}|{member.Summary}|", member.GetCoreMarkdown());
        }

        [Fact]
        public void ToMarkdownTest()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"# {member.Name}");
            builder.AppendLine($"#### {member.Summary}");

            Assert.Equal(builder.ToString(), member.ToMarkdown());
        }

        [Fact]
        public void ToHelpFileTest()
        {
            HelpFile actualHelpFile = member.ToHelpFile();

            Assert.IsType<HelpFile>(actualHelpFile);
            Assert.Equal(member.FileName, actualHelpFile.Name);
            Assert.Equal(member.ToMarkdown(), actualHelpFile.Content);
        }
    }
}
