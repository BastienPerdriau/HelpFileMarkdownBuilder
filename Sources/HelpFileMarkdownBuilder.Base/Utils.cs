using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpFileMarkdownBuilder.Base
{
    /// <summary>
    /// Utils class
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Gets a formated view of a row
        /// </summary>
        /// <param name="properties">Properties to display</param>
        /// <returns>Formated view of a row</returns>
        public static string GetFormatedArrayRowView(IEnumerable<string> properties) => $"|{string.Join("|", properties)}|";

        /// <summary>
        /// Gets the header separating line with the required of columns
        /// </summary>
        /// <param name="numberOfColumns">Number of columns to display</param>
        /// <returns>Formated view of the header separating line</returns>
        public static string GetFormatedArrayHeaderSeparatingLine(int numberOfColumns)
        {
            return GetFormatedArrayRowView(Enumerable.Repeat("-", numberOfColumns));
        }

        /// <summary>
        /// Gets the header of an array with properties header
        /// </summary>
        /// <param name="properties">Properties to display</param>
        /// <returns>Formated view of the header row</returns>
        public static string GetFormatedArrayHeader(IEnumerable<string> properties)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GetFormatedArrayRowView(properties));
            builder.AppendLine(GetFormatedArrayHeaderSeparatingLine(properties.Count()));

            return builder.ToString();
        }

        /// <summary>
        /// Gets the header of an array without headers
        /// </summary>
        /// <param name="numberOfColumns">Number of columns to display</param>
        /// <returns>Formated view of the header row</returns>
        public static string GetFormatedArrayHeader(int numberOfColumns)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(GetFormatedArrayRowView(Enumerable.Repeat(string.Empty, numberOfColumns)));
            builder.AppendLine(GetFormatedArrayHeaderSeparatingLine(numberOfColumns));

            return builder.ToString();
        }
    }
}
