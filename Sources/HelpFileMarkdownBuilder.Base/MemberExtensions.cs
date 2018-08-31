using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Extensions class for Member class
    /// </summary>
    public static class MemberExtensions
    {
        /// <summary>
        /// Gets the value of a member property
        /// </summary>
        /// <typeparam name="T">Member</typeparam>
        /// <param name="member">Member</param>
        /// <param name="property">Property to display</param>
        /// <returns>Value of the member property</returns>
        public static string GetArrayRowValue<T>(this T member, Expression<Func<T, object>> property) where T : Member
        {
            Func<T, object> compiled = property.Compile();
            object value = compiled.Invoke(member);

            if (value != null)
            {
                return value.ToString();
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets an array row view of properties of a member
        /// </summary>
        /// <typeparam name="T">Member</typeparam>
        /// <param name="member">Member</param>
        /// <param name="properties">Properties to display</param>
        /// <returns>Array row view of properties</returns>
        public static string GetArrayRowView<T>(this T member, params Expression<Func<T, object>>[] properties) where T : Member
        {
            return Utils.GetFormatedArrayRowView(properties.Select(p => member.GetArrayRowValue(p)));
        }
    }
}
