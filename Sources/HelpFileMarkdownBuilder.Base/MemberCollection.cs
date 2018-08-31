using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Collection of members
    /// </summary>
    public class MemberCollection<T> : List<T> where T : Member
    {
        /// <summary>
        /// Multiple member type name
        /// </summary>
        public virtual string MultipleMemberTypeName => "Members";

        /// <summary>
        /// Gets a list view of the members
        /// </summary>
        /// <param name="properties">Properties to display</param>
        /// <returns>List view of properties of the members</returns>
        public string GetListView(params Expression<Func<T, object>>[] properties)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(Utils.GetFormatedArrayRowView(properties.Select(p => ((MemberExpression)p.Body).Member.Name)));
            builder.AppendLine(Utils.GetFormatedArrayHeaderRow(properties.Length));
            builder.Append(string.Join(Environment.NewLine, this.Select(m => m.GetArrayRowView(properties))));

            return builder.ToString();
        }

        /// <summary>
        /// Gets a list wiew of core properties of the members
        /// </summary>
        /// <param name="WithTitle">True if the member list is preceded with title, False if not</param>
        /// <returns>List vioew of members</returns>
        public string GetCoreListView(bool WithTitle = true)
        {
            StringBuilder builder = new StringBuilder();

            if (WithTitle)
            {
                builder.AppendLine($"## {MultipleMemberTypeName}");
                builder.AppendLine();
            }

            builder.Append(GetListView(m => m.Name, m => m.Summary));

            return builder.ToString();
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MemberCollection() { }

        /// <summary>
        /// Constructor with list initializer
        /// </summary>
        /// <param name="members">Members</param>
        public MemberCollection(IEnumerable<T> members) : base(members) { }
    }
}
