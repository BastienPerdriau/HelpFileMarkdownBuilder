using System.Collections.Generic;
using System.Linq;

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
        /// Gets the header line with the required of columns
        /// </summary>
        /// <param name="numberOfColumns">Number of columns to display</param>
        /// <returns>Formated view of the header row</returns>
        public static string GetFormatedArrayHeaderRow(int numberOfColumns)
        {
            return GetFormatedArrayRowView(Enumerable.Repeat("-", numberOfColumns));
        }
    }
}
